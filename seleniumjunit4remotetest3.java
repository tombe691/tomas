package com.example.tests;

import com.thoughtworks.selenium.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.util.regex.Pattern;

public class seleniumjunit4remotetest3 {
	private Selenium selenium;

	@Before
	public void setUp() throws Exception {
		selenium = new DefaultSelenium("localhost", 4444, "*chrome", "http://www.vt.se/");
		selenium.start();
	}

	@Test
	public void testSeleniumjunit4remotetest3() throws Exception {
		selenium.open("/nyheter/");
		selenium.click("xpath=(//a[contains(text(),'Norra kommunen')])[2]");
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
