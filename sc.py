import scapy
import logging

logging.getLogger("scapy").setLevel(1)

from scapy.all import *

class Test(Packet):
    name = "Test packet"
    fields_desc = [ ShortField("test1", 1),
                    ShortField("test2", 2) ]

def make_test(x,y):
    return Ether()/IP()/Test(test1=x,test2=y)

sniff(filter="icmp and host 192.168.1.1", count=2)
pkts = sniff(offline="temp.cap")
