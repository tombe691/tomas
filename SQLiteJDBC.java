import java.sql.*;

public class SQLiteJDBC
{
  public static void main( String args[] )
  {
    Connection c = null;
    Statement stmt = null;
    try {
      Class.forName("org.sqlite.JDBC");
      c = DriverManager.getConnection("jdbc:sqlite:test.db");
      c.setAutoCommit(false);
      System.out.println("Opened database successfully");

      stmt = c.createStatement();
      ResultSet rs = stmt.executeQuery( "SELECT * FROM STUDENT WHERE NAMN = 'Tomas' AND KLASS = 'IS15';" );
      while ( rs.next() ) {
         String  name = rs.getString("NAMN");
         int age  = rs.getInt("ALDER");
         String  adress = rs.getString("ADRESS");
         String klass = rs.getString("KLASS");
         System.out.println( "NAME = " + name );
         System.out.println( "AGE = " + age );
         System.out.println( "ADRESS = " + adress );
         System.out.println( "KLASS = " + klass );
         System.out.println();
      }
      rs.close();
      stmt.close();
      c.close();
    } catch ( Exception e ) {
      System.err.println( e.getClass().getName() + ": " + e.getMessage() );
      System.exit(0);
    }
    System.out.println("Operation done successfully");
  }
}
