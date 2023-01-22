using cwiczenia_8_APBD_INT.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cwiczenia_8_APBD_INT.Repository
{
    public interface IHospitalDbRepository
    {
        Task<IEnumerable<DoctorDto>> GetDoctorsAsync();
        Task<string> AddDoctorAsync(DoctorDto dto);
        Task<string> ChangeDoctorAsync(int id, DoctorDto dto);
        Task<string> DeleteDoctorAsync(int id);
        Task<PrescriptionDto> GetPrescriptionAsync(int id);
    }
}