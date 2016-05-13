package com.example.tests;

import com.thoughtworks.selenium.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.util.regex.Pattern;

public class junitremotetest2 {
	private Selenium selenium;

	@Before
	public void setUp() throws Exception {
		selenium = new DefaultSelenium("localhost", 4444, "*chrome", "https://www.google.se/");
		selenium.start();
	}

	@Test
	public void testJunitremotetest2() throws Exception {
		selenium.open("/search?q=www.aftonbladet.se&ie=utf-8&oe=utf-8&gws_rd=cr&ei=flwWV_akO4WqsAGFxYmoCg");
		selenium.click("link=exact:Aftonbladet: Sveriges nyhetskälla och mötesplats");
		selenium.waitForPageToLoad("30000");
		selenium.click("id=yui_3_15_0_2_1461083267355_1340");
		selenium.click("id=yui_3_15_0_2_1461083267355_1366");
		selenium.waitForPageToLoad("30000");
		selenium.click("id=yui_3_15_0_2_1461083276042_1209");
		selenium.waitForPageToLoad("30000");
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
