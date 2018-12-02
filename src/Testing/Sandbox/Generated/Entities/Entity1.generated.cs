//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
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
   [Entity1Attr]
   public partial class Entity1 : INotifyPropertyChanged
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Entity1()
      {
         Entity2 = new System.Collections.Generic.HashSet<Sandbox.Entity2>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_entity2_1"></param>
      public Entity1(Sandbox.Entity2 _entity2_1)
      {
         if (_entity2_1 == null) throw new ArgumentNullException(nameof(_entity2_1));
         Entity2_1 = _entity2_1;

         Entity2 = new HashSet<Sandbox.Entity2>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_entity2_1"></param>
      public static Entity1 Create(Sandbox.Entity2 _entity2_1)
      {
         return new Entity1(_entity2_1);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected int _Id;
      /// <summary>
      /// When provided in a partial class, allows value of _Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         set
         {
            int oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
               OnPropertyChanged();
            }
         }
      }

      /// <summary>
      /// Backing field for Foo
      /// </summary>
      protected string _Foo;
      /// <summary>
      /// When provided in a partial class, allows value of _Foo to be changed before setting.
      /// </summary>
      partial void SetFoo(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of _Foo to be changed before returning.
      /// </summary>
      partial void GetFoo(ref string result);

      [FooAttr]
      public string Foo
      {
         get
         {
            string value = _Foo;
            GetFoo(ref value);
            return (_Foo = value);
         }
         set
         {
            string oldValue = _Foo;
            SetFoo(oldValue, ref value);
            if (oldValue != value)
            {
               _Foo = value;
               OnPropertyChanged();
            }
         }
      }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      [ConcurrencyCheck]
      public byte[] Timestamp { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      public virtual ICollection<Sandbox.Entity2> Entity2 { get; set; }

      protected Sandbox.Entity2 _Entity2_1;
      partial void SetEntity2_1(Sandbox.Entity2 oldValue, ref Sandbox.Entity2 newValue);
      partial void GetEntity2_1(ref Sandbox.Entity2 result);

      /// <summary>
      /// Required
      /// </summary>
      [Entity2_1Attr]
      public Sandbox.Entity2 Entity2_1
      {
         get
         {
            Sandbox.Entity2 value = _Entity2_1;
            GetEntity2_1(ref value);
            return (_Entity2_1 = value);
         }
         set
         {
            Sandbox.Entity2 oldValue = _Entity2_1;
            SetEntity2_1(oldValue, ref value);
            if (oldValue != value)
            {
               _Entity2_1 = value;
               OnPropertyChanged();
            }
         }
      }

      public virtual event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}
