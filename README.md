# ZenikaTechTest

Download or clone the repo and open the RadioactivityMonitor.sln solution in VisualStudio2022.<br/>
It is a .NET 8.0 project.<br/>
Test Framework is MSTest.<br/>

## Assumptions and thought process: 
The purpose of the unit tests are to ensure that the alarm functions as expected.<br/>
The expected behaviour of the alarm is to turn on when the radioactivity value it receives is outside of its lower and upper threshold range.<br/>
No other behaviours are required to be tested for this exercise.<br/>

The unit tests should be performed on the exact same functions that are expected to be used in the final product.<br/>

## Test Cases:
```
lower threshold >  Radioactivity                    [_alarmOn == true]
lower threshold == Radioactivity                    [_alarmOn == false]

lower threshold <  Radioactivity <  upper threshold [_alarmOn == false]

                   Radioactivity >  upper threshold [_alarmOn == true]
                   Radioactivity == upper threshold [_alarmOn == false]
```
## Modifications
To properly test these cases, the Alarm class should be modified to allow unit tests to dictate different radioactivity readings and verify the alarm behaviour.<br/>

The Check() function of the Alarm class should ONLY take in the radioactivity value and check if it is within the threshold range.<br/>
(querying the sensor is outside of its scope of responsibility)<br/>

Ideally there should be a NuclearPowerPlantManager class that manages all the alarms and sensors, plus other classes that trigger feedback mechanisms.<br/>
The Sensor's role is to output radioactivity values.<br/>
The Alarm's role is to turn on when the input radioactivity values are outside of its thresholds.<br/>
The NuclearPowerPlantManager's role is to poll the Sensor values and use the Alarm to check the sensor values.<br/>

## Other minor changes:
The alarm should be turned off when the radioactivity is within the threshold range.<br/>

In the original Check() function, the | OR operator was used instead of ||.<br/>
if (value < LowThreshold | HighThreshold < value)<br/>
As the value cannot be lower than the low threshold and higher than the high threshold at the same time, it is redundant to always evaluate both statements.<br/>
if (value < LowThreshold || HighThreshold < value)<br/>
