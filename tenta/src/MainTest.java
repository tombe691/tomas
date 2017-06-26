import org.junit.Test;
import static org.junit.Assert.*;


public class MainTest {
    //calcPriceAfterDiscount
    //calcPriceMinusVat
    //    calcTotPrice
    // Testar metoden för att ta bort momsen.
    @Test
    public void testNoVat() throws Exception {
        assertEquals(125*0.8, Main.calcPriceMinusVat(125), 0.001);
    }

    // Testar metoden för att ta bort momsen (med assertNotEquals).
    @Test
    public void testNoVatFalse() throws Exception {
        assertEquals(100*0.75, Main.calcPriceMinusVat(100));
    }

    // Testar metoden för att lägga till studentrabatten.
    @Test
    public void testStudentdiscount() throws Exception {
        assertEquals(100*0.93, Main.calcPriceAfterDiscount(100), 0.001);
    }

    // Testar metoden för att lägga till studentrabbaten (med assertNotEquals).
    @Test
    public void testStudentdiscountFalse() {
        assertEquals(125*97, Main.calcPriceAfterDiscount(125), 0.001);
    }

    // Testar metoden för att summera två priser.
    @Test
    public void testSum() throws Exception {
        assertEquals(5, Main.calcTotPrice(2, 3), 0.001);
    }

    // Ett till test för att summera två priser.
    @Test
    public void testSum100() throws Exception{
        assertEquals(100, Main.calcTotPrice(30, 70), 0.001);
    }

    @Test
    public void testSumFalse() throws Exception{
        assertEquals(10, Main.calcTotPrice(2, 2), 0.001);
    }
}
