using FluentNHibernate.Mapping;

namespace MiA.Shared.NHibernate.Mapping.Base
{
  public class CategoryBaseMap : ClassMap<Model.Base.CategoryBase>
  {
    public CategoryBaseMap()
    {
      Table("Categories");
      Id(x => x.Id);
      Map(x => x.TypeGuid).Column("TypeGuid").Not.Insert().Not.Update();
      Map(x => x.Name);

      DiscriminateSubClassesOnColumn("TypeGuid");
    }
  }
}