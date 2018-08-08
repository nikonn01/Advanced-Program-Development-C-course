// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShapeList.cs" company="">
//   
// </copyright>
// <summary>
//   The shape list.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment1B.Controller
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Assignment1B.Model;
    using System.Windows.Forms;

    /// <summary>
    /// The shape list.
    /// </summary>
    /// 

    public sealed class ShapeList : IList<IShape>
    {
        
        private List<IShape> list = new List<IShape>();

       
        public IEnumerator<IShape> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.list).GetEnumerator();
        }

        public void Add(IShape item)
        {
            int a = 0;
            this.list.Add(item);
            this.SetActive(item);
            MessageBox.Show("shape is added");
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

        public bool Remove(IShape item)
        {
            if (this.list.Remove(item))
            {
                if (item.Active && this.list.Count > 0)
                {
                    return this.list[0].Active = true;
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

        public int GetActiveIndex()
        {
            return IndexOf(this.list.FirstOrDefault(w => w.Active));
        }

        public IShape GetActive()
        {
            return this.list.FirstOrDefault(w => w.Active);
        }

        public void SetActive(int index)
        {
            if (index < this.list.Count)
            {
                this.MakeInactive();
                this.list[index].Active = true;
            }
        }

        public void SetActive(IShape item)
        {
            if (this.list.Contains(item))
            {
                this.MakeInactive();
                item.Active = true;
            }
        }

        public void MakeInactive()
        {
            IShape elem = this.list.FirstOrDefault(w => w.Active);
            if (elem != null)
            {
                elem.Active = false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return ((ICollection<IShape>)this.list).IsReadOnly;
            }
        }

        public object ViewList { get { return list; } private set {; } }

        public int IndexOf(IShape item)
        {
            return this.list.IndexOf(item);
        }

        public void Insert(int index, IShape item)
        {
            this.list.Insert(index, item);
            this.SetActive(item);
        }

        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
            if (this.list.Count > 0)
            {
                this.list[0].Active = true;
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
                this.MakeInactive();
                value.Active = true;
                this.list[index] = value;
            }
        }
       
    }
}
