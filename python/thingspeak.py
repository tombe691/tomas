#!/usr/bin/env python
import urllib,json
from urllib.request import urlopen
READ_API_KEY='12W6XONNNMFNHOZ1'
CHANNEL_ID=313361
def main():
    conn = urlopen("http://api.thingspeak.com/channels/%s/feeds/last.json?api_key=%s" \
                           % (CHANNEL_ID,READ_API_KEY))
    response = conn.read()
    print ("http status code=%s" % (conn.getcode()))
    data=json.loads(response)
    print (data['field4'],data['created_at'])
    conn.close()
if __name__ == '__main__':
    main()

