using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_IsATriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(4,4,7));
    }
    [TestMethod]
    public void IsTriangle_IsNotATriangle_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(4, 2, 7));
    }
    [TestMethod]
    public void TypeOfTriangle_IsAnEquilateral_Equilateral()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral", testTriangle.TypeOfTriangle(5, 5, 5));
    }
    [TestMethod]
    public void TypeOfTriangle_IsAnIsosceles_Isosceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.TypeOfTriangle(8, 5, 5));
    }
    [TestMethod]
    public void TypeOfTriangle_IsAScalene_Scalene()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.TypeOfTriangle(2,4,3));
    }
    [TestMethod]
    public void TypeOfTriangle_IsNotATriangle_NotATriangle()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Not a Triangle", testTriangle.TypeOfTriangle(2,4,1));
    }
  }
}