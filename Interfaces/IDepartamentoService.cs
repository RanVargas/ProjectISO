using ProjectISO.Models;
using System.ServiceModel;

namespace ProjectISO.Interfaces
{
    [ServiceContract]
    public interface IDepartamentoService
    {
        [OperationContract]
        Departamento CreateDepartamento(Departamento departamento);

        [OperationContract]
        Departamento GetDepartamentoById(int id);

        [OperationContract]
        List<Departamento> GetAllDepartamentos();

        [OperationContract]
        Departamento UpdateDepartamento(Departamento departamento);

        [OperationContract]
        bool DeleteDepartamentoById(int id);
    }
}
