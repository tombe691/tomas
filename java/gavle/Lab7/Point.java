
/*
  Uppgift4
  Point.
  Tomas Berggren, tombe691@gmail.com
  2019-05-08
*/


public class Point {
    // Instance Variables
    private double x;
    private double y;
    private double z;

    public Point(double x, double y, double z) {
	this.x = x;
	this.y = y;
	this.z = z;
    }

    // method 1
    public String getInfo(Point point) {
        return ("Point cordinates are: x: "+point.x+" y: "+point.y+" z: "+point.z);
    }

    public double[] getValues(Point point)  
    { 
        // returning  array
	double[] arr = new double[3];
	arr[0] = this.x;
	arr[1] = this.y;
	arr[2] = this.z;
        return arr; 
    }

    public double calcDistance(Point pointA, Point pointB)  
    {
	double dist;
	dist = Math.sqrt(Math.pow(pointA.x - pointB.x, 2) +
			 Math.pow(pointA.y - pointB.y, 2) +
			 Math.pow(pointA.z - pointB.z, 2));
        return dist; 
    }

    public double calcDistanceToOrigo(Point pointA)  
    {
	double dist;
        Point pointB = new Point(0, 0, 0);
	dist = Math.sqrt(Math.pow(pointA.x - pointB.x, 2) +
			 Math.pow(pointA.y - pointB.y, 2) +
			 Math.pow(pointA.z - pointB.z, 2));
        return dist; 
    }

    public void test(){
        Point pointA = new Point(0, 0, 0);
        Point pointB = new Point(2, 2, 0);
	double dist = calcDistance(pointA, pointB);
	System.out.println(dist);
    }

    public static void main(String[] args) {
        Point point = new Point(1, 2, 3);
	System.out.println(point.getInfo(point));
	point.test();
    }
}
