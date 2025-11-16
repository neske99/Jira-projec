
public class GetProjectDTO
{
  public int Id { get; set; }
  public string Name { get; set; }=string.Empty;
  public  string Description { get; set; }=string.Empty;
  public int ProjectTypeId { get; set; }
  public int ProjectStatusId { get; set; }
  public string ProjectTypeName { get; set; }=string.Empty;
  public string ProjectStatusName { get; set; }=string.Empty;

}