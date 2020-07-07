using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem.Models
{
    /// <summary>
    /// 종. 값이 변경되면 안됨
    /// </summary>
    ///     
    public enum Genders
    {
        All = 0,
        Male,
        Female
    }

    public enum PhysicalConditionType
    {
        사망=1,
        위험,
        양호
    }

public enum SpeciesType
    {
        개 = 1,
고양이,
새    ,
돼지  ,
소    ,
염소  ,
양    ,
라마  ,
뱀    ,
알파카,
패럿  ,
고슴도치,
토끼  ,
햄스터,
병아리,
    }
}
