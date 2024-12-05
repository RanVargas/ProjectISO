using ProjectISO.Models;
using System.ServiceModel;

namespace ProjectISO.Interfaces
{
    [ServiceContract]
    public interface IActivoService
    {
        [OperationContract]
        Activo CreateActivo(Activo activo);

        [OperationContract]
        Activo GetActivoById(int id);

        [OperationContract]
        List<Activo> GetAllActivos();

        [OperationContract]
        Activo UpdateActivo(Activo activo);

        [OperationContract]
        bool DeleteActivoById(int id);
    }
}
