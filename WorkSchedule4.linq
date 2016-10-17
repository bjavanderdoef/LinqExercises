<Query Kind="Expression">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//// From the shifts scheduled for NAIT's placement contract, show the number of employees needed for each day (ordered by day-of-week). Bonus: display the name of the day of week (first day being Monday).
//
// select DayOfWeek and EmployeesNeeded (SUM of NumberOfEmployees per DayOfWeek) from Shifts
//
//from shift in Shifts
//where shift.PlacementContract.Location.Name.Contains("NAIT")
//group shift by shift.DayOfWeek into tempData
//select new 
//{
//	Day = tempData.Key,
//	EmployeesNeeded = tempData.Sum( x => x.NumberOfEmployees)
//}

from data in Shifts
where data.PlacementContract.Location.Name.Contains("NAIT")
group data by data.DayOfWeek into result
select new
{
	//Day = result.Key,
	DayOfWeek = result.Key == 1 ? "Mon"
			  : result.Key == 2 ? "Tue"
			  : result.Key == 3 ? "Wed"
			  : result.Key == 4 ? "Thu"
			  : "Fri",
	EmployeesNeeded = result.Sum(r => r.NumberOfEmployees)
}