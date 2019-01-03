#! /usr/bin/env python

try:
    # For Python 3.0 and later
    from urllib.request import urlopen
except ImportError:
    # Fall back to Python 2's urllib2
    from urllib2 import urlopen

html = urlopen("http://web.ics.purdue.edu/~gchopra/class/public/pages/webdesign/05_simple.html")
print(html.read())
