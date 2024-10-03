using ISDSupportLogsManager.Client.Contracts.Services;
using ISDSupportLogsManager.Contracts.Repositories;

namespace ISDSupportLogsManager.Services
{
	public class SupportDataService : ISupportDataService
	{
		readonly ISupportRepository _supportRepository;
		readonly IWebHostEnvironment _webHostEnvironment;
		readonly IHttpContextAccessor _httpContextAccessor;

		  public SupportDataService(ISupportRepository supportRepository, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
		{
			_supportRepository = supportRepository;
			_webHostEnvironment = webHostEnvironment;
			_httpContextAccessor = httpContextAccessor;
		}
    }
}
