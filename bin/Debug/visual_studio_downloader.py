import time

try:
    import httplib
except:
    import http.client as httplib

def have_internet():
    conn = httplib.HTTPConnection("www.google.com", timeout=5)
    try:
        conn.request("HEAD", "/")
        conn.close()
        print("network accessed")
        return True
    except:
        conn.close()
        print("network denied")
        return False

if not have_internet() : exit()
else :
    x = input("test end press anything to exit ...")
    exit()

