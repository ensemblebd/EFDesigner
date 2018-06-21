//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sandbox
{
   public partial class Post
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Post()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_blog"></param>
      public Post(Blog _blog)
      {
         if (_blog == null) throw new ArgumentNullException(nameof(_blog));
         Blog = _blog;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_blog"></param>
      public static Post Create(Blog _blog)
      {
         return new Post(_blog);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /// <summary>
      /// Max length = 200
      /// </summary>
      [MaxLength(200)]
      public string Title { get; set; }

      public string Content { get; set; }

      // Persistent navigation properties

      /// <summary>
      ///  // Required
      /// </summary>
      public virtual Blog Blog { get; set; }  // Required
   }
}
