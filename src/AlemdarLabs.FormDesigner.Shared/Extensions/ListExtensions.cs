using System.Collections.Generic;

namespace AlemdarLabs.FormDesigner.Extensions
{
    public static class ListExtensions
    {
        public static void MoveLeft<T>(this List<T> list, T element)
        {
            MoveTo(list, element, false);
        }
        public static void MoveRight<T>(this List<T> list, T element)
        {
            MoveTo(list, element, true);
        }
        public static void MoveTo<T>(this List<T> list, T element, bool right)
        {
            var currentIndex = list.IndexOf(element);
            var newIndex = (currentIndex != 0) ? currentIndex - 1 : 0;

            if (right)
            {
                newIndex = (currentIndex != -1) ? currentIndex + 1 : 1;
            }

            // We already have the item and it's the only one, do nothing
            if (currentIndex != -1 && list.Count == 1)
            {
                return;
            }

            list.RemoveAt(currentIndex);
            list.Insert(newIndex, element);
        }
        public static void MoveTo<T>(this List<T> list, int oldIndex, int newIndex)
        {
            T removedItem = list[oldIndex];

            list.RemoveAt(oldIndex);
            list.Insert(newIndex, removedItem);
        }
        public static bool IsMoveLeftPossible<T>(this List<T> list, T element)
        {
            return list.IndexOf(element) > 0;
        }
        public static bool IsMoveRightPossible<T>(this List<T> list, T element)
        {
            return list.IndexOf(element) < list.Count - 1;
        }
    }
}
