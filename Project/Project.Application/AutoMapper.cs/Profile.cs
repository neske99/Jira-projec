
public class Profile:AutoMapper.Profile
{
  public Profile()
  {
    CreateMap<Project.Domain.Entities.Project.Project,GetProjectDTO>()
    .ForMember(dest=>dest.ProjectTypeName,opt=>opt.MapFrom(src=>src.ProjectType!=null ? src.ProjectType.ProjectTypeName : string.Empty))
    .ForMember(dest=>dest.ProjectStatusName,opt=>opt.MapFrom(src=>src.ProjectStatus!=null ? src.ProjectStatus.StatusName : string.Empty));

  }

}