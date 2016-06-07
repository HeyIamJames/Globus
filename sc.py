import scappy

sniff(filter="icmp and host 192.168.1.1", count=2)
pkts = sniff(offline="temp.cap")