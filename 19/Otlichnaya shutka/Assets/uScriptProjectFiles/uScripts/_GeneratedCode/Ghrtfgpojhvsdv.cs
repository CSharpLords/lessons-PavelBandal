//uScript Generated Code - Build 1.0.3085
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Ghrtfgpojhvsdv : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   UnityEngine.GameObject local_0_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_0_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_2_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_2_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_3_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_3_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_5 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_5 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_5 = "opn";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_5 = (bool) true;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_8 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_8 = "opn";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_8 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_8 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_0_UnityEngine_GameObject = GameObject.Find( "/look" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_0_UnityEngine_GameObject_previous )
         {
            {
               uScript_Trigger component = local_0_UnityEngine_GameObject_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
                  component.OnExitTrigger -= Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
               }
            }
         }
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_0_UnityEngine_GameObject )
         {
            {
               uScript_Trigger component = local_0_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = local_0_UnityEngine_GameObject.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      if ( null == local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_2_UnityEngine_GameObject = GameObject.Find( "/Super Door" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_3_UnityEngine_GameObject = GameObject.Find( "/Super Door" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_0_UnityEngine_GameObject_previous != local_0_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_0_UnityEngine_GameObject_previous )
         {
            {
               uScript_Trigger component = local_0_UnityEngine_GameObject_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
                  component.OnExitTrigger -= Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
               }
            }
         }
         
         local_0_UnityEngine_GameObject_previous = local_0_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_0_UnityEngine_GameObject )
         {
            {
               uScript_Trigger component = local_0_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = local_0_UnityEngine_GameObject.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_0_UnityEngine_GameObject )
      {
         {
            uScript_Trigger component = local_0_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_5.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.SetParent(g);
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnEnterTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void Relay_OnEnterTrigger_1()
   {
      if (true == CheckDebugBreak("ae010d13-5717-45ac-b95f-fe48ab26e8b4", "Trigger_Event", Relay_OnEnterTrigger_1)) return; 
      Relay_In_5();
   }
   
   void Relay_OnExitTrigger_1()
   {
      if (true == CheckDebugBreak("ae010d13-5717-45ac-b95f-fe48ab26e8b4", "Trigger_Event", Relay_OnExitTrigger_1)) return; 
      Relay_In_8();
   }
   
   void Relay_WhileInsideTrigger_1()
   {
      if (true == CheckDebugBreak("ae010d13-5717-45ac-b95f-fe48ab26e8b4", "Trigger_Event", Relay_WhileInsideTrigger_1)) return; 
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("45cb43b0-0292-4445-9b03-4c9b2306b4e2", "Set_Animator_Parameter__Bool_", Relay_In_5)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_5.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_5, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_5[ index++ ] = local_2_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_5.In(logic_uScriptAct_AnimatorSetParameterBool_Target_5, logic_uScriptAct_AnimatorSetParameterBool_Name_5, logic_uScriptAct_AnimatorSetParameterBool_Value_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Ghrtfgpojhvsdv.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f202c3c6-0227-4b45-9280-5725d323aeaf", "Set_Animator_Parameter__Bool_", Relay_In_8)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_8.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_8, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_8[ index++ ] = local_3_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.In(logic_uScriptAct_AnimatorSetParameterBool_Target_8, logic_uScriptAct_AnimatorSetParameterBool_Name_8, logic_uScriptAct_AnimatorSetParameterBool_Value_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Ghrtfgpojhvsdv.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Ghrtfgpojhvsdv.uscript:0", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b7e08bec-070d-485e-a8df-7bc8df548e4e", local_0_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Ghrtfgpojhvsdv.uscript:2", local_2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5ef87117-778f-434d-a467-7c006d3c5459", local_2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Ghrtfgpojhvsdv.uscript:3", local_3_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c0366479-4785-4dd9-9c86-abc143c7854a", local_3_UnityEngine_GameObject);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
