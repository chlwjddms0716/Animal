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
        Male=1,
        Female=2,
      
    }

    public enum PhysicalConditionType
    {
        양호=1,
        위험=2,
        사망 = 3
    }

    public enum AdoptionStatusType
    {
     보호중,
    처리중,
    입양,
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
