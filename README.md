# MQTT-DataAcquisition

The objective is to subscribe to the stream of data from a SQTT server, and send alarm if the value is higer than the threshold for 5 minutes. 

Business rules:
1. If the sensor value is above the threshold for more than 5 minutes, send a HTTP POST alarm. 
2. Send no more alarms if one sent until the value stays under the threshold for 5 mintutes.

Configurable parameters:
1. Threshold
2. REST API address 
Both can be configured in app.config under userSettings section. 

======================================
======================================
Here is an example of the output:

Threshold is 50
REST API: https://jsonplaceholder.typicode.com/posts
Low Flag
Sampled at 2018-04-10T21:25:04.8070870 -   14.71 - T:0.00 - H:False - L:True
Sampled at 2018-04-10T21:25:14.8118720 -   13.48 - T:0.17 - H:False - L:True
Sampled at 2018-04-10T21:25:24.8179140 -   12.43 - T:0.33 - H:False - L:True
Sampled at 2018-04-10T21:25:34.8184950 -   11.56 - T:0.50 - H:False - L:True
Sampled at 2018-04-10T21:25:44.8288670 -   10.88 - T:0.67 - H:False - L:True
Sampled at 2018-04-10T21:25:54.8392650 -   10.40 - T:0.83 - H:False - L:True
Sampled at 2018-04-10T21:26:04.8452810 -   10.10 - T:1.00 - H:False - L:True
Sampled at 2018-04-10T21:26:14.8557150 -   10.00 - T:1.17 - H:False - L:True
Sampled at 2018-04-10T21:26:24.8661780 -   10.09 - T:1.33 - H:False - L:True
Sampled at 2018-04-10T21:26:34.8695520 -   10.38 - T:1.50 - H:False - L:True
Sampled at 2018-04-10T21:26:44.8799350 -   10.87 - T:1.67 - H:False - L:True
Sampled at 2018-04-10T21:26:54.8903060 -   11.54 - T:1.83 - H:False - L:True
Sampled at 2018-04-10T21:27:04.8915440 -   12.40 - T:2.00 - H:False - L:True
Sampled at 2018-04-10T21:27:14.8924140 -   13.45 - T:2.17 - H:False - L:True
Sampled at 2018-04-10T21:27:24.9002460 -   14.67 - T:2.33 - H:False - L:True
Sampled at 2018-04-10T21:27:34.9106450 -   16.06 - T:2.50 - H:False - L:True
Sampled at 2018-04-10T21:27:44.9184770 -   17.63 - T:2.67 - H:False - L:True
Sampled at 2018-04-10T21:27:54.9289680 -   19.35 - T:2.84 - H:False - L:True
Sampled at 2018-04-10T21:28:04.9394290 -   21.21 - T:3.00 - H:False - L:True
Sampled at 2018-04-10T21:28:14.9453220 -   23.22 - T:3.17 - H:False - L:True
Sampled at 2018-04-10T21:28:24.9558110 -   25.36 - T:3.34 - H:False - L:True
Sampled at 2018-04-10T21:28:34.9662280 -   27.62 - T:3.50 - H:False - L:True
Sampled at 2018-04-10T21:28:44.9767260 -   29.99 - T:3.67 - H:False - L:True
Sampled at 2018-04-10T21:28:54.9870380 -   32.46 - T:3.84 - H:False - L:True
Sampled at 2018-04-10T21:29:04.9974170 -   35.02 - T:4.00 - H:False - L:True
Sampled at 2018-04-10T21:29:15.0065160 -   37.64 - T:4.17 - H:False - L:True
Sampled at 2018-04-10T21:29:25.0107800 -   40.33 - T:4.34 - H:False - L:True
Sampled at 2018-04-10T21:29:35.0183710 -   43.06 - T:4.50 - H:False - L:True
Sampled at 2018-04-10T21:29:45.0231430 -   45.83 - T:4.67 - H:False - L:True
Sampled at 2018-04-10T21:29:55.0336050 -   48.61 - T:4.84 - H:False - L:True
High Flag
Sampled at 2018-04-10T21:30:05.0439740 -   51.41 - T:0.00 - H:True - L:False
Sampled at 2018-04-10T21:30:15.0453040 -   54.19 - T:0.17 - H:True - L:False
Sampled at 2018-04-10T21:30:25.0557290 -   56.96 - T:0.33 - H:True - L:False
Sampled at 2018-04-10T21:30:35.0664610 -   59.69 - T:0.50 - H:True - L:False
Sampled at 2018-04-10T21:30:45.0768950 -   62.38 - T:0.67 - H:True - L:False
Sampled at 2018-04-10T21:30:55.0872720 -   65.01 - T:0.83 - H:True - L:False
Sampled at 2018-04-10T21:31:05.0976990 -   67.56 - T:1.00 - H:True - L:False
Sampled at 2018-04-10T21:31:15.1080780 -   70.03 - T:1.17 - H:True - L:False
Sampled at 2018-04-10T21:31:25.1179090 -   72.39 - T:1.33 - H:True - L:False
Sampled at 2018-04-10T21:31:35.1282560 -   74.65 - T:1.50 - H:True - L:False
Sampled at 2018-04-10T21:31:45.1386670 -   76.79 - T:1.67 - H:True - L:False
Sampled at 2018-04-10T21:31:55.1452820 -   78.80 - T:1.84 - H:True - L:False
Sampled at 2018-04-10T21:32:05.1556660 -   80.67 - T:2.00 - H:True - L:False
Sampled at 2018-04-10T21:32:15.1613210 -   82.39 - T:2.17 - H:True - L:False
Sampled at 2018-04-10T21:32:25.1672930 -   83.95 - T:2.34 - H:True - L:False
Sampled at 2018-04-10T21:32:35.1776730 -   85.34 - T:2.50 - H:True - L:False
Sampled at 2018-04-10T21:32:45.1881050 -   86.56 - T:2.67 - H:True - L:False
Sampled at 2018-04-10T21:32:55.1985920 -   87.61 - T:2.84 - H:True - L:False
Sampled at 2018-04-10T21:33:05.2064430 -   88.47 - T:3.00 - H:True - L:False
Sampled at 2018-04-10T21:33:15.2168700 -   89.14 - T:3.17 - H:True - L:False
Sampled at 2018-04-10T21:33:25.2179550 -   89.62 - T:3.34 - H:True - L:False
Sampled at 2018-04-10T21:33:35.2283480 -   89.91 - T:3.50 - H:True - L:False
Sampled at 2018-04-10T21:33:45.2386940 -   90.00 - T:3.67 - H:True - L:False
Sampled at 2018-04-10T21:33:55.2452290 -   89.90 - T:3.84 - H:True - L:False
Sampled at 2018-04-10T21:34:05.2530730 -   89.60 - T:4.00 - H:True - L:False
Sampled at 2018-04-10T21:34:15.2635090 -   89.11 - T:4.17 - H:True - L:False
Sampled at 2018-04-10T21:34:25.2746700 -   88.43 - T:4.34 - H:True - L:False
Sampled at 2018-04-10T21:34:35.2850210 -   87.56 - T:4.50 - H:True - L:False
Sampled at 2018-04-10T21:34:45.2944340 -   86.51 - T:4.67 - H:True - L:False
Sampled at 2018-04-10T21:34:55.2963530 -   85.28 - T:4.84 - H:True - L:False
Alarm sent.
{
  "message": "Threshold value exceeded",
  "lastSensorValue": "83.88",
  "LastSensorTimestamp": "2018-04-10T21:35:05.3066860",
  "id": 101
}
Sampled at 2018-04-10T21:35:05.3066860 -   83.88 - T:5.00 - H:True - L:False
Sampled at 2018-04-10T21:35:15.3171360 -   82.31 - T:5.17 - H:True - L:False
Sampled at 2018-04-10T21:35:25.3277290 -   80.58 - T:5.34 - H:True - L:False
Sampled at 2018-04-10T21:35:35.3336490 -   78.71 - T:5.50 - H:True - L:False
Sampled at 2018-04-10T21:35:45.3440560 -   76.69 - T:5.67 - H:True - L:False
Sampled at 2018-04-10T21:35:55.3502500 -   74.55 - T:5.84 - H:True - L:False
Sampled at 2018-04-10T21:36:05.3513740 -   72.29 - T:6.01 - H:True - L:False
Sampled at 2018-04-10T21:36:15.3533440 -   69.91 - T:6.17 - H:True - L:False
Sampled at 2018-04-10T21:36:25.3543100 -   67.45 - T:6.34 - H:True - L:False
Sampled at 2018-04-10T21:36:35.3580530 -   64.89 - T:6.51 - H:True - L:False
Sampled at 2018-04-10T21:36:45.3683760 -   62.26 - T:6.67 - H:True - L:False
Sampled at 2018-04-10T21:36:55.3788030 -   59.57 - T:6.84 - H:True - L:False
Sampled at 2018-04-10T21:37:05.3892930 -   56.84 - T:7.01 - H:True - L:False
Sampled at 2018-04-10T21:37:15.3948730 -   54.07 - T:7.17 - H:True - L:False
Sampled at 2018-04-10T21:37:25.4053040 -   51.28 - T:7.34 - H:True - L:False
Low Flag
Sampled at 2018-04-10T21:37:35.4157130 -   48.49 - T:0.00 - H:False - L:True
Sampled at 2018-04-10T21:37:45.4179710 -   45.70 - T:0.17 - H:False - L:True
Sampled at 2018-04-10T21:37:55.4234350 -   42.94 - T:0.33 - H:False - L:True
Sampled at 2018-04-10T21:38:05.4338460 -   40.21 - T:0.50 - H:False - L:True
Sampled at 2018-04-10T21:38:15.4345010 -   37.52 - T:0.67 - H:False - L:True
Sampled at 2018-04-10T21:38:25.4449250 -   34.90 - T:0.83 - H:False - L:True
Sampled at 2018-04-10T21:38:35.4556320 -   32.35 - T:1.00 - H:False - L:True
Sampled at 2018-04-10T21:38:45.4660070 -   29.89 - T:1.17 - H:False - L:True
Sampled at 2018-04-10T21:38:55.4764850 -   27.52 - T:1.33 - H:False - L:True
Sampled at 2018-04-10T21:39:05.4868460 -   25.27 - T:1.50 - H:False - L:True
Sampled at 2018-04-10T21:39:15.4877960 -   23.13 - T:1.67 - H:False - L:True
Sampled at 2018-04-10T21:39:25.4981830 -   21.13 - T:1.83 - H:False - L:True
Sampled at 2018-04-10T21:39:35.5085510 -   19.27 - T:2.00 - H:False - L:True
Sampled at 2018-04-10T21:39:45.5176520 -   17.55 - T:2.17 - H:False - L:True
Sampled at 2018-04-10T21:39:55.5279180 -   16.00 - T:2.34 - H:False - L:True
Sampled at 2018-04-10T21:40:05.5367880 -   14.61 - T:2.50 - H:False - L:True
Sampled at 2018-04-10T21:40:15.5467570 -   13.40 - T:2.67 - H:False - L:True
Sampled at 2018-04-10T21:40:25.5480140 -   12.36 - T:2.84 - H:False - L:True
Sampled at 2018-04-10T21:40:35.5583840 -   11.51 - T:3.00 - H:False - L:True
Sampled at 2018-04-10T21:40:45.5626880 -   10.84 - T:3.17 - H:False - L:True
Sampled at 2018-04-10T21:40:55.5672610 -   10.37 - T:3.34 - H:False - L:True
Sampled at 2018-04-10T21:41:05.5776650 -   10.09 - T:3.50 - H:False - L:True
Sampled at 2018-04-10T21:41:15.5880700 -   10.00 - T:3.67 - H:False - L:True
Sampled at 2018-04-10T21:41:25.5984420 -   10.11 - T:3.84 - H:False - L:True
Sampled at 2018-04-10T21:41:35.6088270 -   10.41 - T:4.00 - H:False - L:True
Sampled at 2018-04-10T21:41:45.6184910 -   10.91 - T:4.17 - H:False - L:True
Sampled at 2018-04-10T21:41:55.6288500 -   11.60 - T:4.34 - H:False - L:True
Sampled at 2018-04-10T21:42:05.6391890 -   12.47 - T:4.50 - H:False - L:True
Sampled at 2018-04-10T21:42:15.6484000 -   13.53 - T:4.67 - H:False - L:True
Sampled at 2018-04-10T21:42:25.6523790 -   14.77 - T:4.84 - H:False - L:True
Sampled at 2018-04-10T21:42:35.6530830 -   16.18 - T:5.00 - H:False - L:True
Sampled at 2018-04-10T21:42:45.6624770 -   17.75 - T:5.17 - H:False - L:True
Sampled at 2018-04-10T21:42:55.6728570 -   19.48 - T:5.34 - H:False - L:True
Sampled at 2018-04-10T21:43:05.6753960 -   21.36 - T:5.50 - H:False - L:True
Sampled at 2018-04-10T21:43:15.6858490 -   23.38 - T:5.67 - H:False - L:True
Sampled at 2018-04-10T21:43:25.6962270 -   25.53 - T:5.84 - H:False - L:True
Sampled at 2018-04-10T21:43:35.7066620 -   27.80 - T:6.00 - H:False - L:True
Sampled at 2018-04-10T21:43:45.7172470 -   30.17 - T:6.17 - H:False - L:True
Sampled at 2018-04-10T21:43:55.7270650 -   32.65 - T:6.34 - H:False - L:True
Sampled at 2018-04-10T21:44:05.7375100 -   35.21 - T:6.51 - H:False - L:True
Sampled at 2018-04-10T21:44:15.7425610 -   37.84 - T:6.67 - H:False - L:True
Sampled at 2018-04-10T21:44:25.7455630 -   40.53 - T:6.84 - H:False - L:True
Sampled at 2018-04-10T21:44:35.7505640 -   43.26 - T:7.01 - H:False - L:True
Sampled at 2018-04-10T21:44:45.7610560 -   46.03 - T:7.17 - H:False - L:True
Sampled at 2018-04-10T21:44:55.7714920 -   48.82 - T:7.34 - H:False - L:True
High Flag
Sampled at 2018-04-10T21:45:05.7818300 -   51.61 - T:0.00 - H:True - L:False
Sampled at 2018-04-10T21:45:15.7905460 -   54.40 - T:0.17 - H:True - L:False
Sampled at 2018-04-10T21:45:25.8010290 -   57.17 - T:0.33 - H:True - L:False
Sampled at 2018-04-10T21:45:35.8114510 -   59.90 - T:0.50 - H:True - L:False
Sampled at 2018-04-10T21:45:45.8143790 -   62.58 - T:0.67 - H:True - L:False
Sampled at 2018-04-10T21:45:55.8179650 -   65.20 - T:0.83 - H:True - L:False
Sampled at 2018-04-10T21:46:05.8285890 -   67.74 - T:1.00 - H:True - L:False
Sampled at 2018-04-10T21:46:15.8305700 -   70.20 - T:1.17 - H:True - L:False
Sampled at 2018-04-10T21:46:25.8409630 -   72.56 - T:1.33 - H:True - L:False
Sampled at 2018-04-10T21:46:35.8422920 -   74.81 - T:1.50 - H:True - L:False
Sampled at 2018-04-10T21:46:45.8452910 -   76.94 - T:1.67 - H:True - L:False
Sampled at 2018-04-10T21:46:55.8557910 -   78.94 - T:1.83 - H:True - L:False
Sampled at 2018-04-10T21:47:05.8626220 -   80.80 - T:2.00 - H:True - L:False
Sampled at 2018-04-10T21:47:15.8731440 -   82.50 - T:2.17 - H:True - L:False
Sampled at 2018-04-10T21:47:25.8822690 -   84.05 - T:2.34 - H:True - L:False
Sampled at 2018-04-10T21:47:35.8928710 -   85.43 - T:2.50 - H:True - L:False
Sampled at 2018-04-10T21:47:45.9033220 -   86.64 - T:2.67 - H:True - L:False
Sampled at 2018-04-10T21:47:55.9055430 -   87.67 - T:2.84 - H:True - L:False
Sampled at 2018-04-10T21:48:05.9160040 -   88.52 - T:3.00 - H:True - L:False
Sampled at 2018-04-10T21:48:15.9180180 -   89.18 - T:3.17 - H:True - L:False
Sampled at 2018-04-10T21:48:25.9278100 -   89.65 - T:3.34 - H:True - L:False
Sampled at 2018-04-10T21:48:35.9382830 -   89.92 - T:3.50 - H:True - L:False
Sampled at 2018-04-10T21:48:45.9452620 -   90.00 - T:3.67 - H:True - L:False
Sampled at 2018-04-10T21:48:55.9558010 -   89.88 - T:3.84 - H:True - L:False
Sampled at 2018-04-10T21:49:05.9644770 -   89.57 - T:4.00 - H:True - L:False
Sampled at 2018-04-10T21:49:15.9749210 -   89.07 - T:4.17 - H:True - L:False
Sampled at 2018-04-10T21:49:25.9853690 -   88.37 - T:4.34 - H:True - L:False
Sampled at 2018-04-10T21:49:35.9871140 -   87.49 - T:4.50 - H:True - L:False
Sampled at 2018-04-10T21:49:45.9945330 -   86.43 - T:4.67 - H:True - L:False
Sampled at 2018-04-10T21:49:56.0050060 -   85.19 - T:4.84 - H:True - L:False
Alarm sent.
{
  "message": "Threshold value exceeded",
  "lastSensorValue": "83.77",
  "LastSensorTimestamp": "2018-04-10T21:50:06.0155130",
  "id": 101
}
Sampled at 2018-04-10T21:50:06.0155130 -   83.77 - T:5.00 - H:True - L:False
Sampled at 2018-04-10T21:50:16.0180170 -   82.19 - T:5.17 - H:True - L:False
Sampled at 2018-04-10T21:50:26.0252190 -   80.46 - T:5.34 - H:True - L:False
Sampled at 2018-04-10T21:50:36.0357010 -   78.57 - T:5.50 - H:True - L:False
Sampled at 2018-04-10T21:50:46.0452680 -   76.55 - T:5.67 - H:True - L:False
Sampled at 2018-04-10T21:50:56.0557340 -   74.39 - T:5.84 - H:True - L:False
Sampled at 2018-04-10T21:51:06.0591630 -   72.12 - T:6.00 - H:True - L:False
Sampled at 2018-04-10T21:51:16.0696770 -   69.74 - T:6.17 - H:True - L:False
Sampled at 2018-04-10T21:51:26.0801990 -   67.26 - T:6.34 - H:True - L:False
Sampled at 2018-04-10T21:51:36.0905470 -   64.70 - T:6.51 - H:True - L:False
Sampled at 2018-04-10T21:51:46.1009680 -   62.07 - T:6.67 - H:True - L:False
Sampled at 2018-04-10T21:51:56.1114300 -   59.38 - T:6.84 - H:True - L:False
Sampled at 2018-04-10T21:52:06.1145040 -   56.64 - T:7.01 - H:True - L:False
Sampled at 2018-04-10T21:52:16.1224830 -   53.87 - T:7.17 - H:True - L:False
Sampled at 2018-04-10T21:52:26.1238020 -   51.08 - T:7.34 - H:True - L:False
Low Flag
Sampled at 2018-04-10T21:52:36.1342710 -   48.29 - T:0.00 - H:False - L:True
Sampled at 2018-04-10T21:52:46.1447190 -   45.50 - T:0.17 - H:False - L:True
Sampled at 2018-04-10T21:52:56.1452410 -   42.74 - T:0.33 - H:False - L:True
Sampled at 2018-04-10T21:53:06.1555740 -   40.01 - T:0.50 - H:False - L:True
Sampled at 2018-04-10T21:53:16.1659950 -   37.33 - T:0.67 - H:False - L:True
Sampled at 2018-04-10T21:53:26.1765140 -   34.71 - T:0.83 - H:False - L:True
Sampled at 2018-04-10T21:53:36.1780620 -   32.17 - T:1.00 - H:False - L:True
Sampled at 2018-04-10T21:53:46.1889290 -   29.71 - T:1.17 - H:False - L:True
Sampled at 2018-04-10T21:53:56.1993950 -   27.36 - T:1.33 - H:False - L:True
Sampled at 2018-04-10T21:54:06.2079190 -   25.11 - T:1.50 - H:False - L:True
Sampled at 2018-04-10T21:54:16.2181670 -   22.98 - T:1.67 - H:False - L:True
Sampled at 2018-04-10T21:54:26.2187870 -   20.99 - T:1.83 - H:False - L:True
Sampled at 2018-04-10T21:54:36.2236380 -   19.14 - T:2.00 - H:False - L:True
Sampled at 2018-04-10T21:54:46.2340030 -   17.44 - T:2.17 - H:False - L:True
Sampled at 2018-04-10T21:54:56.2443820 -   15.90 - T:2.34 - H:False - L:True
