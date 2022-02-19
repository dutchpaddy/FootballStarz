using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using System.ComponentModel.DataAnnotations;

namespace FootballStarz.Validator
{
    public class ClubLogoValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Club club = (Club)validationContext.ObjectInstance;
            if (!ValidationSupport.CheckImageFormat(club.ClubLogo))
            {
                return new ValidationResult("Club logo: Image format .jpg is required. Try again!");
            }
            return ValidationResult.Success;
        }
    }

    public class PlayerImageValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Player player = (Player)validationContext.ObjectInstance;
            if (!ValidationSupport.CheckImageFormat(player.PlayerImage))
            {
                return new ValidationResult("Player image: Image format .jpg is required. Try again!");
            }
            return ValidationResult.Success;
        }
    }


    public class StadiumImageValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Stadium stadium = (Stadium)validationContext.ObjectInstance;
            if (!ValidationSupport.CheckImageFormat(stadium.StadiumImage))
            {
                return new ValidationResult("Stadium image: Image format .jpg is required. Try again!");
            }
            return ValidationResult.Success;
        }
    }

    static class ValidationSupport
    {
        public static bool CheckImageFormat(string fmt)
        {
            bool ret = false;
            if (fmt == null)
            {
                    return true;
            }
            if (fmt.Substring(fmt.Length - 4, 4).ToUpper() == ".JPG")
            {
                    ret = true;
            }
            
            return ret;
        }
    }

}
