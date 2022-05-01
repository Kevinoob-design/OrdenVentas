using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenVentas.shared
{
    internal static class Utils
    {
        public static Dictionary<string, string> GetCollectionKeyValueFromControlsTags(params Control[] controls)
        {
            Dictionary<string, string> collection = new Dictionary<string, string>();

            foreach (var control in controls)
            {
                bool isButtonOrLabel = control is Button || control is Label;
                bool hasTagAndTextValue = control.Tag != "" && control.Text != "";

                if (!isButtonOrLabel && hasTagAndTextValue)
                {
                    bool isKeyValueOnCollection = collection.ContainsKey(control.Tag.ToString());

                    if (!isKeyValueOnCollection)
                    {
                        collection[control.Tag.ToString()] = control.Text;
                    }
                    else
                    {
                        collection[control.Tag.ToString()] += " " + control.Text;
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
    }
}
