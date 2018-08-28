public interface ILand
{
    string TransmissionType { get; set; }
    double MaxLandSpeed { get; set; }

    void Drive();
}