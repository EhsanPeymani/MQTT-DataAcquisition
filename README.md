# MQTT-DataAcquisition

The objective is to subscribe to the stream of data from a SQTT server, and send alarm if the value is higer than the threshold for 5 minutes. 

Business rules:
1. If the sensor value is above the threshold for more than 5 minutes, send a HTTP POST alarm. 
2. Send no more alarms if one sent until the value stays under the threshold for 5 mintutes.

Configurable parameters:
1. Threshold
2. REST API address 
Both can be configured in app.config under userSettings section. 

