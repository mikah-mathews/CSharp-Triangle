namespace TriangleTracker
{
  public class Triangle
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1 + side2) > side3 && (side2 + side3) > side1 && (side1 + side3) > side2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string TypeOfTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        return "Equilateral";
      }
      else if(side1 == side2 || side2 == side3 || side3 == side1)
      {
        return "Isosceles";
      }
      else if (side1 != side2 && side2 != side3 && side3 != side1 && IsTriangle(side1, side2, side3))
      {
        return "Scalene";
      }
      else
      {
        return "Not a Triangle";
      }
    }
  }
}