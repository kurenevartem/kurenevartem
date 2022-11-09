
// Ассоциация
class Microcontroller
{ }
class Modules
{
    public Microcontroller Processor_module { get; set; }
    public Microcontroller Power_supply_unit { get; set; }
    public Microcontroller Input_modules { get; set; }
    public Microcontroller Output_modules { get; set; }

}


//Агрегация
public abstract class Sensors
{ }
public class MFK1500
{
    Sensors sensors;
    public MFK1500 (Sensors sens)
    {
        sensors = sens;
    }
}


//Композиция
public class Executive_and_regulating_devices
{ }
public class Siemens_simatic_s7
{
    Executive_and_regulating_devices devices;
    public Siemens_simatic_s7()
    {
        devices = new Executive_and_regulating_devices();
    }
}