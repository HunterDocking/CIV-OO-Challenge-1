using System;
using Shapes.Classes;
using NUnit.Framework;

namespace Quadrilateral_Tests {
    [TestFixture]
    public class Tests {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }
       
        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }



        //3. ADD TO EXISTING TESTS
        //
        //
        Square sq3 { get; set; }
        Square sq4 { get; set; }
        Square sq5 { get; set; }

        Rectangle rec3 { get; set; }
        Rectangle rec4 { get; set; }
        Rectangle rec5 { get; set; }


        [SetUp]
        public void Init() {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);
            
            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);



            //3. ADD TO EXISTING TESTS
            //
            //

            sq3 = new Square("", 5);
            sq4 = new Square("", 15);
            sq5 = new Square("", 7);

            rec3 = new Rectangle("", 5, 10);
            rec4 = new Rectangle("", 4, 6);
            rec5 = new Rectangle("", 9, 7);

        }

        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;
            
            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());
            
            area = 36;
            perimeter = 24;
            
            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());



            //3. ADD TO EXISTING TESTS
            //
            //

            area = 25;
            perimeter = 20;

            Assert.AreEqual(area, sq3.GetArea());
            Assert.AreEqual(perimeter, sq3.GetPerimeter());

            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, sq4.GetArea());
            Assert.AreEqual(perimeter, sq4.GetPerimeter());

            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, sq5.GetArea());
            Assert.AreEqual(perimeter, sq5.GetPerimeter());

        }

        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;
            
            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;
            
            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());



            //3. ADD TO EXISTING TESTS
            //
            //

            area = 50;
            perimeter = 30;

            Assert.AreEqual(area, rec3.GetArea());
            Assert.AreEqual(perimeter, rec3.GetPerimeter());

            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, rec4.GetArea());
            Assert.AreEqual(perimeter, rec4.GetPerimeter());

            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, rec5.GetArea());
            Assert.AreEqual(perimeter, rec5.GetPerimeter());
        }

    }
}