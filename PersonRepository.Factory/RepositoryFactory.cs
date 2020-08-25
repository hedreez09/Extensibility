using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System;

namespace PersonRepository.Factory
{
	public class RepositoryFactory
	{
		public static IPersonRepository GetRepository(string repositroyType)
		{
			IPersonRepository repository = null;
			switch (repositroyType)
			{
				case "Service": repository = new ServiceRepository();
					break;
				case "CSV": repository = new CSVRepository();
					break;
				case "SQL":repository = new SQLRepository();
					break;
				default:
					throw new ArgumentException("Invalid repository type");
			}
			return repository;
		} 
	}
}
