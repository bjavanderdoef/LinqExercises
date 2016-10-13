<Query Kind="Statements">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// From the shifts scheduled for NAIT's placement contract, show the number of employees needed for each day (ordered by day-of-week). Bonus: display the name of the day of week (first day being Monday).

// select DayOfWeek and EmployeesNeeded (SUM of NumberOfEmployees per DayOfWeek) from Shifts


//from contract in PlacementContracts
//where contract.Location.Name.Contains("NAIT")
//select new
//{
//	
//}
where shift.PlacementContract.Location.Name.Contains("NAIT") create temp variable

from shift in Shifts
where shift.PlacementContractID == (from contract in PlacementContracts where contract.Location.Name.Contains("NAIT") select contract.PlacementContractID).Single()
select shift


from shift in Shifts
where shift.PlacementContractID == (from contract in PlacementContracts where contract.Location.Name.Contains("NAIT") select contract.PlacementContractID).Single()
select new
{
	DayOfWeek = shift.DayOfWeek,
	EmployeesNeeded = shift.NumberOfEmployees
}


(from shift in Shifts
where shift.PlacementContractID == (from contract in PlacementContracts where contract.Location.Name.Contains("NAIT") select contract.PlacementContractID).Single()
select new
{
	//DayOfWeek = shift.DayOfWeek,
	EmployeesNeeded = shift.NumberOfEmployees.AsEnumerable().Count()
}).Distinct()