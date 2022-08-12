using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using AOP.ObjectPooling;
using AOP.UI;
using AOP.UI.Windows;

namespace AOP.DataCenter
{
    [CreateAssetMenu(fileName = "AOP-UI-UIPrefabsDataSO", menuName = "AOP/Data/UIPrefabsDataSO")]
    public class UIPrefabsSO : IPrefabsContainerSO
    {
        public AssetReference EntryWindowReferance;
        public AssetReference MainMenuWindowReferance;
        public AssetReference LoadingWindowReferance;

        public override void RegisterPrefabsToPool()
        {
            ObjectCamp.RegisterPrefab(new TypePrefabRegisterMap(typeof(IUIWindow), EntryWindowReferance, WindowTitles.EntryWindow));
            ObjectCamp.RegisterPrefab(new TypePrefabRegisterMap(typeof(IUIWindow), MainMenuWindowReferance, WindowTitles.MainMenuWindow));
            ObjectCamp.RegisterPrefab(new TypePrefabRegisterMap(typeof(IUIWindow), LoadingWindowReferance, WindowTitles.LoadingWindow));
        }
    }
}