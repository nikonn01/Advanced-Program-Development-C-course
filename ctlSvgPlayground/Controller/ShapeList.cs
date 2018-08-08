// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeList.cs" company="">
//   
// </copyright>
// <summary>
//   The shape list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ctlSvgPlayground.Controller
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    using ctlSvgPlayground.Model;

    /// <summary>
    /// The shape list.
    /// </summary>
    [Serializable]
    public sealed class ShapeList : IList<IShape>
    {
        /// <summary>
        /// The list of shapes.
        /// </summary>
        private List<IShape> list = new List<IShape>();

        /// <summary>
        /// The filter.
        /// </summary>
        private string filter;

        /// <summary>
        /// Prevents a default instance of the <see cref="ShapeList"/> class from being created. Singletone pattern.
        /// </summary>
        private ShapeList() { }

        /// <summary>
        /// The only instance of ShapeList.
        /// </summary>
        private static ShapeList instance = new ShapeList();

        /// <summary>
        /// To get instance of ShapeList.
        /// </summary>
        /// <returns>
        /// The <see cref="ShapeList"/>.
        /// </returns>
        public static ShapeList GetInstance()
        {
            return instance;
        }

        #region IList interface support

        public IEnumerator<IShape> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.list).GetEnumerator();
        }

        /// <summary>
        /// The add method & focus.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Add(IShape item)
        {
            this.list.Add(item);
            SetFilter(this.filter);
            this.SetActive(item);
        }

        public void Clear()
        {
            this.list.Clear();
        }

        public bool Contains(IShape item)
        {
            return this.list.Contains(item);
        }

        public void CopyTo(IShape[] array, int arrayIndex)
        {
            this.list.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// The remove method.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Remove(IShape item)
        {
            if (this.list.Remove(item))
            {
                if (item.Active && this.list.Count > 0)
                {
                    return SetActive(list[this.list.Count - 1]);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<IShape>)this.list).IsReadOnly;
            }
        }

        public int IndexOf(IShape item)
        {
            return this.list.IndexOf(item);
        }

        /// <summary>
        /// To insert item and make it active.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Insert(int index, IShape item)
        {
            this.list.Insert(index, item);
            SetFilter(this.filter);
            this.SetActive(item);
        }

        /// <summary>
        /// To remove item by index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
            if (this.list.Count > 0)
            {
                SetActive(list[this.list.Count - 1]);
            }
        }

        public IShape this[int index]
        {
            get
            {
                return this.list[index];
            }

            set
            {
                this.list[index] = value;
                SetFilter(this.filter);
                SetActive(value);
            }
        }

        #endregion

        #region ShapeList specific functionality

        /// <summary>
        /// The get active shape.
        /// </summary>
        /// <returns>
        /// The <see cref="IShape"/>.
        /// </returns>
        public IShape GetActive()
        {
            return this.list.FirstOrDefault(w => w.Active);
        }

        /// <summary>
        /// To setup Shape in active mode.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool SetActive(IShape item)
        {
            if (this.list.Contains(item) && !item.Hidden)
            {
                this.MakeInactive();
                item.Active = true;
                List<IShape> depList = this.list.Where(w => w.Owner == item).ToList();
                this.list = this.list.Except(depList).OrderBy(o => o.Active).ToList();
                this.list.InsertRange(this.list.Count, depList);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// To make one/all items inactive.
        /// </summary>
        public void MakeInactive(IShape active = null)
        {
            if (active == null)
            {
                foreach (IShape shape in this.list)
                {
                    shape.Active = false;
                }
            }
            else
            {
                active.Active = false;
            }
        }

        /// <summary>
        /// The save collections into the stream.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        public void SaveCollections(Stream stream)
        {
            if (this.list.Count < 1)
            {
                throw new Exception("List is empty, nothing to store.");
            }

            BinaryFormatter fmt = new BinaryFormatter();
            if (this.list != null && this.list.Count > 0)
            {
                fmt.Serialize(stream, this.list);
            }
        }

        /// <summary>
        /// The load collections from the stream.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        public void LoadCollections(Stream stream)
        {
            BinaryFormatter fmt = new BinaryFormatter();
            if (stream.Length > 0)
            {
                this.list = (List<IShape>)fmt.Deserialize(stream);
            }
            else
            {
                throw new Exception("File is empty, nothing to load.");
            }
        }

        /// <summary>
        /// The set filter.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        public void SetFilter(string filter)
        {
            this.filter = filter;
            if (filter==null||filter.Equals(string.Empty))
            {
                foreach (IShape shape in this.list.Where(w => w.Hidden))
                {
                    shape.Hidden = false;
                }
                return;
            }

            foreach (IShape shape in this.list.Where(w => w.ToString.ToLower().Equals(filter) && w.Hidden))
            {
                shape.Hidden = false;
            }
            foreach (IShape shape in this.list.Where(w => !w.ToString.ToLower().Equals(filter) && !w.Hidden))
            {
                shape.Hidden = true;
            }
        }

        #endregion
    }
}
