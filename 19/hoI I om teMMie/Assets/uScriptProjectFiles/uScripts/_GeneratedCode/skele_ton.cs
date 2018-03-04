//uScript Generated Code - Build 1.0.3085
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class skele_ton : uScriptLogic
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
   public System.Boolean Drug = (bool) false;
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_0 = null;
   UnityEngine.GameObject owner_Connection_5 = null;
   UnityEngine.GameObject owner_Connection_7 = null;
   UnityEngine.GameObject owner_Connection_9 = null;
   UnityEngine.GameObject owner_Connection_11 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_2 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_2 = true;
   bool logic_uScriptCon_CompareBool_False_2 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_4 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_4 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_4 = "Dance";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_4 = (bool) true;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_6 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_6 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_6 = "Fight!!!";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_6 = (bool) true;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_8 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_8 = "Dance";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_8 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_10 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_10 = "Fight!!!";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_10 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_10 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_0 || false == m_RegisteredForEvents )
      {
         owner_Connection_0 = parentGameObject;
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Trigger>();
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
      if ( null == owner_Connection_5 || false == m_RegisteredForEvents )
      {
         owner_Connection_5 = parentGameObject;
      }
      if ( null == owner_Connection_7 || false == m_RegisteredForEvents )
      {
         owner_Connection_7 = parentGameObject;
      }
      if ( null == owner_Connection_9 || false == m_RegisteredForEvents )
      {
         owner_Connection_9 = parentGameObject;
      }
      if ( null == owner_Connection_11 || false == m_RegisteredForEvents )
      {
         owner_Connection_11 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_0 )
         {
            {
               uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = owner_Connection_0.AddComponent<uScript_Trigger>();
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
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_0 )
      {
         {
            uScript_Trigger component = owner_Connection_0.GetComponent<uScript_Trigger>();
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
      
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_4.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_6.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10.SetParent(g);
      owner_Connection_0 = parentGameObject;
      owner_Connection_5 = parentGameObject;
      owner_Connection_7 = parentGameObject;
      owner_Connection_9 = parentGameObject;
      owner_Connection_11 = parentGameObject;
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
      if (true == CheckDebugBreak("46a7fdca-6222-49e8-b2c6-58c7638a8c14", "Trigger_Event", Relay_OnEnterTrigger_1)) return; 
      Relay_In_2();
   }
   
   void Relay_OnExitTrigger_1()
   {
      if (true == CheckDebugBreak("46a7fdca-6222-49e8-b2c6-58c7638a8c14", "Trigger_Event", Relay_OnExitTrigger_1)) return; 
      Relay_In_8();
   }
   
   void Relay_WhileInsideTrigger_1()
   {
      if (true == CheckDebugBreak("46a7fdca-6222-49e8-b2c6-58c7638a8c14", "Trigger_Event", Relay_WhileInsideTrigger_1)) return; 
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("04edd35b-5c55-4521-8b4d-d856323c016c", "Compare_Bool", Relay_In_2)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_2 = Drug;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.In(logic_uScriptCon_CompareBool_Bool_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.True;
         bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_2.False;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
         if ( test_1 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript skele_ton.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("6b5f7a01-dbe9-4c36-b47d-033a523d2e5b", "Set_Animator_Parameter__Bool_", Relay_In_4)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_4, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_4[ index++ ] = owner_Connection_5;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_4.In(logic_uScriptAct_AnimatorSetParameterBool_Target_4, logic_uScriptAct_AnimatorSetParameterBool_Name_4, logic_uScriptAct_AnimatorSetParameterBool_Value_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript skele_ton.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("025cafde-6196-4d0c-bb4d-4f90de638b8a", "Set_Animator_Parameter__Bool_", Relay_In_6)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_6.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_6, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_6[ index++ ] = owner_Connection_7;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_6.In(logic_uScriptAct_AnimatorSetParameterBool_Target_6, logic_uScriptAct_AnimatorSetParameterBool_Name_6, logic_uScriptAct_AnimatorSetParameterBool_Value_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript skele_ton.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d10e538f-5efd-4654-b25c-df78e8db8ed2", "Set_Animator_Parameter__Bool_", Relay_In_8)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_8.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_8, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_8[ index++ ] = owner_Connection_9;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.In(logic_uScriptAct_AnimatorSetParameterBool_Target_8, logic_uScriptAct_AnimatorSetParameterBool_Name_8, logic_uScriptAct_AnimatorSetParameterBool_Value_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript skele_ton.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e723190c-0520-4f1f-bee0-e908043d5d64", "Set_Animator_Parameter__Bool_", Relay_In_10)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_AnimatorSetParameterBool_Target_10.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_10, index + 1);
               }
               logic_uScriptAct_AnimatorSetParameterBool_Target_10[ index++ ] = owner_Connection_11;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10.In(logic_uScriptAct_AnimatorSetParameterBool_Target_10, logic_uScriptAct_AnimatorSetParameterBool_Name_10, logic_uScriptAct_AnimatorSetParameterBool_Value_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript skele_ton.uscript at Set Animator Parameter (Bool).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "skele_ton.uscript:Drug", Drug);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c1344d5f-771d-4451-a0d1-c0734b9bbe97", Drug);
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
