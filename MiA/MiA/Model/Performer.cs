﻿namespace MiA.Model
{
  public class Performer
  {
    public bool Active { get; set; }
    //public int? AssignmentCompletion { get; }
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public int Id { get; set; }
    public string JobTitle { get; set; }
    public string Name { get; set; }
  }
}