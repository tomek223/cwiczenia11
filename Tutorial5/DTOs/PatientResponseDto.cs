namespace Tutorial5.DTOs;

public class PatientResponseDto
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime Birthdate { get; set; }
    public List<PrescriptionInfoDto> Prescriptions { get; set; } = new();
}