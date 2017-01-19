namespace TelepathyLabsBlenceTest.Common
{

	//public class LoggingAsynchronousOperationInterceptionBehavior : IInterceptionBehavior
	//{
	//	private readonly ConcurrentDictionary<Type, Func<Task, IMethodInvocation, Task>> wrapperCreators =
	//		new ConcurrentDictionary<Type, Func<Task, IMethodInvocation, Task>>();

	//	public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
	//	{
	//		IMethodReturn value = getNext()(input, getNext);
	//		var method = input.MethodBase as MethodInfo;

	//		if (value.ReturnValue != null
	//		    && method != null
	//		    && typeof(Task).IsAssignableFrom(method.ReturnType))
	//		{
	//			// if this method returns a Task, override the original return value
	//			var task = (Task) value.ReturnValue;
	//			return input.CreateMethodReturn(this.GetWrapperCreator(method.ReturnType)(task, input), value.Outputs);
	//		}

	//		return value;
	//	}

	//	private Func<Task, IMethodInvocation, Task> GetWrapperCreator(Type taskType)
	//	{
	//		return this.wrapperCreators.GetOrAdd(
	//			taskType,
	//			(Type t) =>
	//			{
	//				if (t == typeof(Task))
	//				{
	//					return this.CreateWrapperTask;
	//				}
	//				else if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Task<>))
	//				{
	//					return (Func<Task, IMethodInvocation, Task>) this.GetType()
	//						.GetMethod("CreateGenericWrapperTask", BindingFlags.Instance | BindingFlags.NonPublic)
	//						.MakeGenericMethod(new Type[] {t.GenericTypeArguments[0]})
	//						.CreateDelegate(typeof(Func<Task, IMethodInvocation, Task>), this);

	//				}
	//				else
	//				{
	//					// other cases are not supported
	//					return (task, _) => task;
	//				}
	//			});
	//	}

	//	private async Task CreateWrapperTask(Task task, IMethodInvocation input)
	//	{
	//		try
	//		{
	//			await task.ConfigureAwait(false);
	//			Trace.TraceInformation("Successfully finished async operation {0}", input.MethodBase.Name);
	//		}
	//		catch (Exception e)
	//		{
	//			Trace.TraceWarning("Async operation {0} threw: {1}", input.MethodBase.Name, e);
	//			throw;
	//		}
	//	}



	//	private Task CreateGenericWrapperTask<T>(Task task, IMethodInvocation input)
	//	{
	//		return this.DoCreateGenericWrapperTask<T>((Task<T>) task, input);
	//	}

	//	private async Task<T> DoCreateGenericWrapperTask<T>(Task<T> task, IMethodInvocation input)
	//	{
	//		try
	//		{
	//			T value = await task.ConfigureAwait(false);
	//			Trace.TraceInformation("Successfully finished async operation {0} with value: {1}", input.MethodBase.Name, value);
	//			return value;
	//		}
	//		catch (Exception e)
	//		{
	//			Trace.TraceWarning("Async operation {0} threw: {1}", input.MethodBase.Name, e);
	//			throw;
	//		}
	//	}

	//	#region additional interception behavior methods

	//	public IEnumerable<Type> GetRequiredInterfaces()
	//	{
	//		return Type.EmptyTypes;
	//	}

	//	public bool WillExecute
	//	{
	//		get { return true; }
	//	}

	//	#endregion
	//}
}
