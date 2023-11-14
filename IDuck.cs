public class DroneAdapter : IDuck
{
    private Drone _drone;

    public DroneAdapter(Drone drone)
    {
        _drone = drone;
    }

    public void Quack()
    {
        _drone.beep();
    }

    public void Fly()
    {
        _drone.spin_rotors();
        _drone.take_off();
    }
}
