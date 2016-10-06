<Query Kind="Expression">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// Show all skills requiring a ticket and which employees have those skills. Include all the data as seen in the following image.
from item in Skills
where item.RequiresTicket == true
orderby item.Description
select new
{
	Description = item.Description,
	Employees = from empSkills in item.EmployeeSkills select new
	{
		Name = empSkills.Employee.FirstName + " " + empSkills.Employee.LastName,
		Level = empSkills.Level,
		YearsExperience = empSkills.YearsOfExperience,
	}
}

//from item in EmployeeSkills
//select new
//{
//	Description = item.Skills.Description,
//	Employees = from select new
//				{
//					Name = item.Employee.FirstName + " " + item.Employee.LastName,
//					Level = item.Level,
//					YearsExperience = item.YearsOfExperience
//				}
//}