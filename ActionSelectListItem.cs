using System.Web.Mvc;

namespace IntraCoffee.Domain.Mvc
{
    /// <summary>
    /// Представляет выбранный элемент в экземпляре класса <see cref="T:dmp.Domain.Mvc.ActionSelectListItem"/>.
    /// </summary>
    public class ActionSelectListItem : SelectListItem
    {
        /// <summary>
        /// Получает или задает аттрибуты выбранного элемента.
        /// </summary>
        /// <returns>
        /// Аттрибуты.
        /// </returns>
        public object Attributes { get; set; }

        public string Indent { get; set; }
    } 
}
