<Query Kind="Expression">
  <Connection>
    <ID>f63d7f1b-c0cd-4efb-a857-b4d18946fd7f</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//// From the shifts scheduled for NAIT's placement contract, show the number of employees needed for each day (ordered by day-of-week). Bonus: display the name of the day of week (first day being Monday).
//
// select DayOfWeek and EmployeesNeeded (SUM of NumberOfEmployees per DayOfWeek) from Shifts
//
from shift in Shifts
where shift.PlacementContract.Location.Name.Contains("NAIT")
group shift by shift.DayOfWeek into tempData
select new 
{
	Day = tempData.Key,
	EmployeesNeeded = tempData.Sum( x => x.NumberOfEmployees)
}