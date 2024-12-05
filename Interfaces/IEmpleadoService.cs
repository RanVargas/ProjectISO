using ProjectISO.Models;
using System.ServiceModel;

namespace ProjectISO.Interfaces
{

    [ServiceContract]
    public interface IEmpleadoService
    {
        [OperationContract]
        Empleado CreateEmpleado(Empleado empleado);

        [OperationContract]
        Empleado GetEmpleadoById(int id);

        [OperationContract]
        List<Empleado> GetAllEmpleados();

        [OperationContract]
        Empleado UpdateEmpleado(Empleado empleado);

        [OperationContract]
        bool DeleteEmpleadoById(int id);
    }
}
