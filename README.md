# ZenikaTechTest

Assumptions and thought process: 
The purpose of the unit tests are to ensure that the alarm functions as expected.
The expexted behaviour of the alarm is to turn on when the radioactivity value it receives is outside of its lower and upper threshold range.
No other behaviours are required to be tested.

The unit tests should be performed on the exact same functions that are expected to be used in the final product.

Test Cases:
lower threshold >  Radioactivity                    [_alarmOn == true]
lower threshold == Radioactivity                    [_alarmOn == false]

lower threshold <  Radioactivity <  upper threshold [_alarmOn == false]

                   Radioactivity >  upper threshold [_alarmOn == true]
                   Radioactivity == upper threshold [_alarmOn == false]


To properly test these cases, the Alarm class should be modified to allow unit tests to dictate different radioactivity readings and verrify the alarm behaviour.

The Check() function of the Alarm class should ONLY take in the radioactivity value and check if it is within the threshold range.
(querying the sensor is outside of its scope of responsilibty)

Ideally there should be a NuclearPowerPlantManager class that manages all the alarms and sensors, plus other classes that trigger feedback mechanisms. 
