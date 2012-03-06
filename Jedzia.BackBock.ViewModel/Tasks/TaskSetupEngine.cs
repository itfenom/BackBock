﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using Jedzia.BackBock.Tasks;
using Microsoft.Build.Framework;
using System.Xml;
using System.IO;
using Jedzia.BackBock.ViewModel.Data;
using System.Collections.ObjectModel;
using Microsoft.Build.Tasks;
using System.ComponentModel;
using System.Reflection;
using Jedzia.BackBock.ViewModel.Util;

namespace Jedzia.BackBock.ViewModel.Tasks
{

    internal class EventSource : IEventSource
    {

        AnyEventHandler anyEventRaised;
        BuildFinishedEventHandler buildFinished;
        BuildStartedEventHandler buildStarted;
        CustomBuildEventHandler customEventRaised;
        BuildErrorEventHandler errorRaised;
        BuildMessageEventHandler messageRaised;
        ProjectFinishedEventHandler projectFinished;
        ProjectStartedEventHandler projectStarted;
        BuildStatusEventHandler statusEventRaised;
        TargetFinishedEventHandler targetFinished;
        TargetStartedEventHandler targetStarted;
        TaskFinishedEventHandler taskFinished;
        TaskStartedEventHandler taskStarted;
        BuildWarningEventHandler warningRaised;
        bool onlyLogCriticalEvents;

        public EventSource()
        {
            this.onlyLogCriticalEvents = false;
        }

        public void FireCustomEventRaised(object sender, CustomBuildEventArgs cbea)
        {
            if (customEventRaised != null)
                customEventRaised(sender, cbea);
            FireAnyEvent(sender, cbea);
        }
        public void FireErrorRaised(object sender, BuildErrorEventArgs beea)
        {
            if (errorRaised != null)
                errorRaised(sender, beea);
            FireAnyEvent(sender, beea);
        }
        public void FireMessageRaised(object sender, BuildMessageEventArgs bmea)
        {
            if (messageRaised != null)
                messageRaised(sender, bmea);
            FireAnyEvent(sender, bmea);
        }
        public void FireWarningRaised(object sender, BuildWarningEventArgs bwea)
        {
            if (warningRaised != null)
                warningRaised(sender, bwea);
            FireAnyEvent(sender, bwea);
        }

        public void FireTargetStarted(object sender, TargetStartedEventArgs tsea)
        {
            if (targetStarted != null)
                targetStarted(sender, tsea);
            FireAnyEvent(sender, tsea);
        }

        public void FireTargetFinished(object sender, TargetFinishedEventArgs tfea)
        {
            if (targetFinished != null)
                targetFinished(sender, tfea);
            FireAnyEvent(sender, tfea);
        }

        public void FireBuildStarted(object sender, BuildStartedEventArgs bsea)
        {
            if (buildStarted != null)
                buildStarted(sender, bsea);
            FireAnyEvent(sender, bsea);
        }

        public void FireBuildFinished(object sender, BuildFinishedEventArgs bfea)
        {
            if (buildFinished != null)
                buildFinished(sender, bfea);
            FireAnyEvent(sender, bfea);
        }

        public void FireProjectStarted(object sender, ProjectStartedEventArgs psea)
        {
            if (projectStarted != null)
                projectStarted(sender, psea);
            FireAnyEvent(sender, psea);
        }

        public void FireProjectFinished(object sender, ProjectFinishedEventArgs pfea)
        {
            if (projectFinished != null)
                projectFinished(sender, pfea);
            FireAnyEvent(sender, pfea);
        }

        public void FireTaskStarted(object sender, TaskStartedEventArgs tsea)
        {
            if (taskStarted != null)
                taskStarted(sender, tsea);
            FireAnyEvent(sender, tsea);
        }

        public void FireTaskFinished(object sender, TaskFinishedEventArgs tfea)
        {
            if (taskFinished != null)
                taskFinished(sender, tfea);
            FireAnyEvent(sender, tfea);
        }

        public void FireAnyEvent(object sender, BuildEventArgs bea)
        {
            if (anyEventRaised != null)
                anyEventRaised(sender, bea);
        }

        public event AnyEventHandler AnyEventRaised
        {
            add
            {
                lock (this)
                    anyEventRaised += value;
            }
            remove
            {
                lock (this)
                    anyEventRaised -= value;
            }
        }

        public event BuildFinishedEventHandler BuildFinished
        {
            add
            {
                lock (this)
                    buildFinished += value;
            }
            remove
            {
                lock (this)
                    buildFinished -= value;
            }
        }

        public event BuildStartedEventHandler BuildStarted
        {
            add
            {
                lock (this)
                    buildStarted += value;
            }
            remove
            {
                lock (this)
                    buildStarted -= value;
            }
        }

        public event CustomBuildEventHandler CustomEventRaised
        {
            add
            {
                lock (this)
                    customEventRaised += value;
            }
            remove
            {
                lock (this)
                    customEventRaised -= value;
            }
        }

        public event BuildErrorEventHandler ErrorRaised
        {
            add
            {
                lock (this)
                    errorRaised += value;
            }
            remove
            {
                lock (this)
                    errorRaised -= value;
            }
        }

        public event BuildMessageEventHandler MessageRaised
        {
            add
            {
                lock (this)
                    messageRaised += value;
            }
            remove
            {
                lock (this)
                    messageRaised -= value;
            }
        }

        public event ProjectFinishedEventHandler ProjectFinished
        {
            add
            {
                lock (this)
                    projectFinished += value;
            }
            remove
            {
                lock (this)
                    projectFinished -= value;
            }
        }

        public event ProjectStartedEventHandler ProjectStarted
        {
            add
            {
                lock (this)
                    projectStarted += value;
            }
            remove
            {
                lock (this)
                    projectStarted -= value;
            }
        }

        public event BuildStatusEventHandler StatusEventRaised
        {
            add
            {
                lock (this)
                    statusEventRaised += value;
            }
            remove
            {
                lock (this)
                    statusEventRaised -= value;
            }
        }

        public event TargetFinishedEventHandler TargetFinished
        {
            add
            {
                lock (this)
                    targetFinished += value;
            }
            remove
            {
                lock (this)
                    targetFinished -= value;
            }
        }

        public event TargetStartedEventHandler TargetStarted
        {
            add
            {
                lock (this)
                    targetStarted += value;
            }
            remove
            {
                lock (this)
                    targetStarted -= value;
            }
        }

        public event TaskFinishedEventHandler TaskFinished
        {
            add
            {
                lock (this)
                    taskFinished += value;
            }
            remove
            {
                lock (this)
                    taskFinished -= value;
            }
        }

        public event TaskStartedEventHandler TaskStarted
        {
            add
            {
                lock (this)
                    taskStarted += value;
            }
            remove
            {
                lock (this)
                    taskStarted -= value;
            }
        }

        public event BuildWarningEventHandler WarningRaised
        {
            add
            {
                lock (this)
                    warningRaised += value;
            }
            remove
            {
                lock (this)
                    warningRaised -= value;
            }
        }

        public bool OnlyLogCriticalEvents
        {
            get { return onlyLogCriticalEvents; }
            set { onlyLogCriticalEvents = value; }
        }
    }

    internal sealed class TaskSetupEngine : IDisposable
    {
        ITaskService taskService;
        private const string fullrecursivePattern = "**";
        private IEnumerable<PathViewModel> Paths { get; set; }
        private INotifyPropertyChanged taskChanged;
        private ITask taskInWork;
        private ILogger logger;
        private EventSource eventSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSetupEngine"/> class.
        /// </summary>
        /// <param name="taskService">The task service that provides task instance generation.</param>
        /// <param name="paths">The paths to setup the task.</param>
        /// <param name="taskChanged">The notifier to look on for task type changes.</param>
        public TaskSetupEngine(
            ITaskService taskService,
            ILogger logger, 
            IEnumerable<PathViewModel> paths, 
            INotifyPropertyChanged taskChanged)
        {
            Guard.NotNull(() => taskService, taskService);
            Guard.NotNull(() => paths, paths);

            this.taskService = taskService;
            this.logger = logger;
            this.Paths = paths;
            this.taskChanged = taskChanged;
            if (taskChanged != null)
            {
                this.taskChanged.PropertyChanged += Task_PropertyChanged;
            }
            this.eventSource = new EventSource();

            if (logger != null)
            {
                logger.Initialize(this.eventSource);
            }
            LogMessage("Initialized");
        }

        private void LogMessage(string message)
        {
            eventSource.FireMessageRaised(this,
                new BuildMessageEventArgs(
                    message,
                    "",
                    this.GetType().Name,
                    MessageImportance.Low
                    ));
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this.taskChanged != null)
            {
                this.taskChanged.PropertyChanged -= Task_PropertyChanged;
                this.taskChanged = null;
            }
            this.taskService = null;
            this.Paths = null;
            this.taskInWork = null;
        }

        #endregion


        /// <summary>
        /// Prepares a task for display with an editor.
        /// </summary>
        /// <param name="taskTypeName">Name of the task type to instantiate.</param>
        /// <param name="taskAttributes">A list with the task attributes data.</param>
        /// <returns>A new task of the specified type, initialized with the data from the
        /// <paramref name="taskAttributes"/> list of Xml attributes.</returns>
        public ITask InitTaskEditor(string taskTypeName, IEnumerable<XmlAttribute> taskAttributes)
        {

            //var taskService = SimpleIoc.Default.GetInstance<ITaskService>();
            var task = taskService[taskTypeName];
            if (task == null)
            {
                return null;
            }

            foreach (var item in taskAttributes)
            {
                var taskType = task.GetType();
                var property = taskType.GetProperty(item.Name);
                if (property == null)
                {
                    // Log property not found.
                    continue;
                }
                if (property.PropertyType.IsArray)
                {
                    // Log skipping array type.
                    continue;
                }
                if (property != null)
                {
                    object val = item.Value;
                    if (property.PropertyType.Name == "ITaskItem")
                    {
                        val = new TaskItem(item.Value);
                    }
                    else
                    {
                        // try
                        //{
                        val = Convert.ChangeType(item.Value, property.PropertyType);
                        //}
                        //catch (Exception ex)
                        // {
                        // }
                    }
                    property.SetValue(task, val, null);
                }
            }

            //var dst = this.Task.data.AnyAttr.Where((e) => e.Name == "DestinationFolder").FirstOrDefault();
            /*if (dst != null)
            {
                var val = dst.Value;
            }*/
            PrepareTask(task);
            taskInWork = task;
            return task;
            //var str = XamlSerializer.Save(task);
            //SerializeTest(task);
        }


        /// <summary>
        /// Prepares the 'SourceFiles', etc., TaskItem data.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <remarks>
        /// This is experimental. Uncommenting the "cr.Execute()" line below, fills the
        /// SourceFiles property of a Backup-Task in the editor with the evaluated path data. 
        /// A CreateItem task is used to mimic the work of a project build engine.
        /// </remarks>
        private void PrepareTask(ITask task)
        {
            // Todo: put this task generation extra.
            /*for (int index = 0; index < this.Paths.Count; index++)
            {
                var item = this.Paths[index];
            }*/
            int xasd = 0;
            var result = this.Paths.Select((e) =>
            {
                var cr = new CreateItem();
                if (e.Inclusions.Count > 0)
                {
                    cr.Include = e.Inclusions.Select(
                        (t) =>
                        {
                            if (e.Path.EndsWith("\\"))
                            {
                                return new TaskItem(e.Path + t.Pattern);
                            }
                            else
                                return new TaskItem(e.Path + "\\" + t.Pattern);
                        }
                        ).ToArray();
                }
                else
                {
                    ITaskItem taskItem;
                    var finfo = new FileInfo(e.Path);
                    if (Directory.Exists(e.Path))
                    {
                        // a directory
                        taskItem = new TaskItem(e.Path + "\\" + fullrecursivePattern);
                    }
                    else
                    {
                        // a file
                        taskItem = new TaskItem(e.Path);
                    }
                    cr.Include = new[] { taskItem };
                }

                cr.Exclude = e.Exclusions.Select((t) => { return new TaskItem(e.Path + "\\" + t.Pattern); }).ToArray();

                // at the moment, do not execute the items.
                //cr.Execute();

                return cr;
            }
            );

            if (task is Backup)
            {
                var btask = (Backup)task;

                //var res = result.ToArray();
                var includes = result.SelectMany((e) => e.Include);
                btask.SourceFiles = includes.ToArray();
                //btask.DestinationFolder = new TaskItem(@"C:\tmp\%(RecursiveDir)");
                //var itemsByType = new Hashtable();
                //foreach (var item in btask.SourceFiles)
                //{
                //itemsByType.Add(
                //}
                //var bla = ItemExpander.ItemizeItemVector(@"@(File)", null, itemsByType);
                // Todo: do i need the build engine ?
                //btask.BuildEngine = this.BuildEngine;
            }
        }


        /// <summary>
        /// Work after the task was modified.
        /// </summary>
        /// <param name="task">The task, that was modified.</param>
        /// <param name="taskAttributes">The list of task attributes to serialize the task data to.</param>
        public void AfterTask(ITask task, ICollection<XmlAttribute> taskAttributes)
        {
            //var task = taskInWork;
            if (task is Backup)
            {
                //var btask = (Backup)task;
                //btask.SourceFiles = new[] { new TaskItem(@"C:\Fuck\der.txt") };
            }

            try
            {
                /*var prj = new Project(Engine.GlobalEngine, "3.5");
                Target target = prj.Targets.AddNewTarget("target");
                var te = new TaskEngine(prj);
                var parameters = new Dictionary<string, string>();
                te.Prepare(task, target.TargetElement, parameters, task.GetType());
                te.PublishOutput();*/

                var properties = task.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance
                        | BindingFlags.IgnoreCase);
                foreach (PropertyInfo pi in properties)
                {
                    bool is_required = pi.IsDefined(typeof(RequiredAttribute), false);
                    bool is_output = pi.IsDefined(typeof(OutputAttribute), false);
                    Type prop_type = pi.PropertyType;
                    if (prop_type.IsArray)
                        prop_type = prop_type.GetElementType();
                    if (!prop_type.IsPrimitive && prop_type != typeof(string) && prop_type != typeof(ITaskItem))
                    {
                        continue;
                    }

                    if (!is_output)
                    {
                        var val = pi.GetValue(task, null);
                        if (val != null)
                        {
                            if (pi.PropertyType.IsArray)
                            {
                                continue;
                            }
                            TypeConverter converter = TypeDescriptor.GetConverter(val.GetType());
                            var lattr = SelectMatchingAttribute(taskAttributes, pi.Name);
                            if (lattr != null)
                            {
                                //TaskItem x = new TaskItem();

                                var xxxy = val.GetType();
                                if (val == null)
                                {
                                    //Todo: default value exclusion.
                                }
                                lattr.Value = (string)converter.ConvertTo(val, typeof(string));
                            }
                            else
                            {
                                var xdoc = new XmlDocument();
                                var attr = xdoc.CreateAttribute(pi.Name);
                                if (pi.PropertyType.Name == "ITaskItem")
                                {
                                }
                                attr.Value = (string)converter.ConvertTo(val, typeof(string));
                                taskAttributes.Add(attr);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Todo: log me.
            }


        }

        private static XmlAttribute SelectMatchingAttribute(IEnumerable<XmlAttribute> attributes, string name)
        {
            var lattr = attributes.Where(e => e.Name == name).FirstOrDefault();
            return lattr;
        }




        private void Task_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TypeName")
            {
                var tvm = (TaskViewModel)sender;
                tvm.data.AnyAttr.Clear();

                var task = InitTaskEditor(tvm.TypeName, tvm.data.AnyAttr);
                tvm.TaskInstance = task;

                tvm.data.OnPropertyChanged("AnyAttr");
            }
        }



    }
}