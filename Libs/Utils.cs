using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Libs
{
    public static class Utils
    {
        public static Dictionary<string, string> GetCollectionKeyValueFromControlsTags(params Control[] controls)
        {
            Dictionary<string, string> collection = new Dictionary<string, string>();

            foreach (var control in controls)
            {
                bool isButtonOrLabel = control is Button || control is Label;
                string tag = control.Tag != null ? control.Tag.ToString() : "";
                bool hasTagAndTextIsNotEmpty = tag.Length > 0;

                if (!isButtonOrLabel && hasTagAndTextIsNotEmpty)
                {
                    bool isKeyValueOnCollection = collection.ContainsKey(tag);

                    if (!isKeyValueOnCollection)
                    {
                        collection[tag] = control.Text;
                    }
                    else
                    {
                        collection[tag] += $" {control.Text}";
                    }
                }

                IEnumerable<Control> childControls = control.Controls.OfType<Control>();

                if (childControls != null)
                {
                    foreach (var child in childControls)
                    {
                        collection = collection.Concat(GetCollectionKeyValueFromControlsTags(child)).ToDictionary(x => x.Key, x => x.Value);
                    }
                }
            }

            return collection;
        }

        public static void SetControlsChildWithValueFromCollection<T>(T collection, params Control[] controls)
        {
            foreach (var control in controls)
            {
                string tag = control.Tag != null ? control.Tag.ToString() : "";
                bool hasTagAndIsNotEmpty = tag.Length > 0;

                if (hasTagAndIsNotEmpty)
                {
                    Type type = typeof(T);
                    control.Text = type.GetProperty(tag)?.GetValue(collection).ToString();
                }

                IEnumerable<Control> childControls = control.Controls.OfType<Control>();

                if (childControls != null)
                {
                    foreach (var child in childControls)
                    {
                        SetControlsChildWithValueFromCollection(collection, child);
                    }
                }
            }
        }

        public static T MapBoxedFromKeyValue<T>(T Source, string key, object value) where T : new()
        {
            Type type = typeof(T);

            object boxed = Source;

            type.GetProperty(key)?.SetValue(boxed, value);

            return (T)boxed;
        }
    }
}
