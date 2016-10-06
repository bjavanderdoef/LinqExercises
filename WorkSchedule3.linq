<Query Kind="Expression">
  <Connection>
    <ID>1ca4c2aa-2d76-4fd3-81eb-94d8b91ffbc4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// List all the skills for which we do not have any qualfied employees. [count of employeeID for skill == 0]
//from item in Skills
//select item.Description

//from empSkill in EmployeeSkills
//where empSkill.EmployeeID.Count() == 0
//select new 
//{ empSkill.Skill.Description
//
//
//
// var menuData = from category in MenuCategories
//			   	select new // Anonymous type
//				{
//					Category = category.Description,
//					ItemCount = category.Items.Count()
//				};
//menuData.Dump("Menu Categories");


from skill in Skills
select new
{
	
}