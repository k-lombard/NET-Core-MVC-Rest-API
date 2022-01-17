
using WebApp.Models;
namespace WebApp.Data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);

    }
}