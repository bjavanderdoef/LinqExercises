<Query Kind="Statements">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the employees with the most years of experience.
//from person in EmployeeSkills
//where person.YearsOfExperience == EmployeeSkills.Max(year => year.YearsOfExperience)
//select new
//{
//	Name = person.Employee.FirstName + " " + person.Employee.LastName,			
//}

var allPeople = from person in Employees
				select new
				{
					Name = person.FirstName,
					TotalYears = person.EmployeeSkills.Sum(x => x.YearsOfExperience)
				};
//allPeople.Dump();
var mostExperienced = from person in allPeople
						where person.TotalYears == allPeople.Max(x => x.TotalYears)
						select person;
mostExperienced.Dump();