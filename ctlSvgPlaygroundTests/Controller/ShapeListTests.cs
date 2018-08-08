using Microsoft.VisualStudio.TestTools.UnitTesting;
using ctlSvgPlayground.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctlSvgPlayground.Controller.Tests
{
    using ctlSvgPlayground.Model;

    [TestClass()]
    public class ShapeListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ShapeList shapeList = ShapeList.GetInstance();
            IShape manShape = new PlaneShape();
            shapeList.Add(manShape);
            int indexMan = shapeList.IndexOf(manShape);

            Assert.IsTrue(shapeList[indexMan].Active);

            IShape womanShape = new HelicopterShape();
            shapeList.Insert(1, womanShape);
            int indexWoman = shapeList.IndexOf(womanShape);

            Assert.IsTrue(shapeList[indexWoman].Active);

            Assert.IsFalse(shapeList[indexMan].Active);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            ShapeList shapeList = ShapeList.GetInstance();

            IShape manShape = new PlaneShape();
            shapeList.Add(manShape);

            IShape womanShape = new HelicopterShape();
            shapeList.Insert(0, womanShape);
            int indexWoman = shapeList.IndexOf(womanShape);
            int indexMan = shapeList.IndexOf(manShape);

            Assert.IsTrue(shapeList[indexWoman].Active);

            Assert.IsFalse(shapeList[indexMan].Active);

            shapeList.Remove(womanShape);
            indexMan = shapeList.IndexOf(manShape);
            Assert.IsTrue(shapeList[indexMan].Active);
        }

        [TestMethod()]
        public void SetActiveTest()
        {
            ShapeList shapeList = ShapeList.GetInstance();

            IShape manShape = new PlaneShape();
            shapeList.Add(manShape);

            IShape womanShape = new HelicopterShape();
            shapeList.Insert(0, womanShape);

            Assert.IsTrue(womanShape.Active);

            Assert.IsFalse(manShape.Active);

            shapeList.SetActive(manShape);

            Assert.IsTrue(manShape.Active);

            IShape bigCar = new BigCar();
            shapeList.Add(bigCar);

            manShape.Owner = bigCar;
            shapeList.SetActive(bigCar);

            Assert.IsTrue(shapeList[shapeList.Count - 1] == manShape);
            Assert.IsTrue(shapeList[shapeList.Count - 2] == bigCar);
        }

        [TestMethod()]
        public void InsertTest()
        {
            ShapeList shapeList = ShapeList.GetInstance();

            IShape manShape = new PlaneShape();
            shapeList.Add(manShape);

            IShape womanShape = new HelicopterShape();
            shapeList.Insert(0, womanShape);
            int indexWoman = shapeList.IndexOf(womanShape);
            int indexMan = shapeList.IndexOf(manShape);

            Assert.IsTrue(shapeList[indexWoman].Active);

            Assert.IsFalse(shapeList[indexMan].Active);
        }

        [TestMethod()]
        public void RemoveAtTest()
        {
            ShapeList shapeList = ShapeList.GetInstance();

            IShape manShape = new PlaneShape();
            shapeList.Add(manShape);

            IShape womanShape = new HelicopterShape();
            shapeList.Insert(0, womanShape);
            int indexWoman = shapeList.IndexOf(womanShape);
            int indexMan = shapeList.IndexOf(manShape);

            Assert.IsTrue(shapeList[indexWoman].Active);

            Assert.IsFalse(shapeList[indexMan].Active);

            shapeList.RemoveAt(indexWoman);

            Assert.IsTrue(shapeList[0].Active);
        }
    }
}