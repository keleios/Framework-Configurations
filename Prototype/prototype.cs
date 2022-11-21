/*
 * R e a d m e
 * -----------
 * 
 * In this file you can include any instructions or other comments you want to have injected onto the 
 * top of your final script. You can safely delete this file if you do not want any such comments.
 */
П ы;Program(){ы=new П(this);Runtime.UpdateFrequency=UpdateFrequency.Update1;ы.б("intel",new څ());var қ=new ԋ("LG");қ.Ԏ(
"command",new Ɓ());қ.Ԏ("lidar",new ŝ());қ.Ԏ("combat",new ű());ы.б("lookingglass",қ);ы.б("scanner",new þ());ы.б("torpedo",new Ͳ())
;ы.б("hangar",new خ());ы.Ю();}void Save(){Storage=ы.Э();}void Main(string Қ,UpdateType ҙ){ы.ʝ(Қ,ҙ);}
}public interface Ҙ{void җ();bool Җ(П Ō,Ҿ ѯ,long ғ);void ҕ(П Ō,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ,long ғ);MyTuple<Ӄ,long>?Ҕ(П
Ō,object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ,long ғ);void Ғ(П Ō,object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ,ref List<MyTuple<Ӄ,
long>>ґ,long ғ);}public static class Ґ{public const string Ҝ="[FLTINT-RPT]",Ҩ="[FLTINT-SYN]",ҧ="[FLTINT-SUB]",Ҧ=
"[FLTINT-PRI]",ҥ="[FLTINT-PRI-REQ]",Ҥ="[FLTTM]";public class ң<Ң,ҡ>:Ҙ where Ң:Ҿ,new(){public ImmutableArray<MyTuple<long,ҡ>>.Builder ū
=ImmutableArray.CreateBuilder<MyTuple<long,ҡ>>(64);public Ң Ҡ=new Ң();public void җ(){Ҡ.Ї(Ҡ.Ј(),null);}public bool Җ(П Ō,
Ҿ ѯ,long ғ){if(ѯ is Ң){Ō.Н.SendBroadcastMessage(Ҝ,MyTuple.Create(ғ,(ҡ)ѯ.Ј()));return true;}return false;}public void ҕ(П
Ō,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ,long ғ){ū.Clear();foreach(var t in ŭ){if(Ҡ.Ы==t.Key.Item1)ū.Add(MyTuple.Create(ғ,(ҡ)t.
Value.Ј()));}Ō.Н.SendBroadcastMessage(Ҩ,ū.ToImmutable());}public MyTuple<Ӄ,long>?Ҕ(П Ō,object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>
ŭ,long ғ){if(Ϥ is MyTuple<long,ҡ>){MyTuple<long,ҡ>ϣ=(MyTuple<long,ҡ>)Ϥ;if(ϣ.Item1!=ғ)return null;return Ҡ.Ї(ϣ.Item2,ŭ);}
return null;}public void Ғ(П Ō,object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ,ref List<MyTuple<Ӄ,long>>ґ,long ғ){if(Ϥ is
ImmutableArray<MyTuple<long,ҡ>>){var Ҟ=(ImmutableArray<MyTuple<long,ҡ>>)Ϥ;foreach(var ѯ in Ҟ){if(ѯ.Item1!=ғ)continue;ҡ ҝ=ѯ.Item2;var ҟ
=Ҡ.Ї(ҝ,ŭ);if(ҟ!=null)ґ.Add(ҟ.Value);}}}}public static int ҏ(Ҿ º,Ҿ Ŗ){return º.Ћ.CompareTo(Ŗ.Ћ);}public static MyTuple<Ӄ,
long>Ѱ(Ҿ ѯ){return MyTuple.Create(ѯ.Ы,ѯ.ќ);}}public enum Ѯ{ѭ,Ѭ,ѫ}public enum А{Ĺ,Ѫ,ѩ,Ѩ,ѧ,Ѧ}[Flags]public enum ł{Ĺ=0,ѥ=1<<0,Ѥ
=1<<1,ѣ=1<<2,Ѣ=1<<10,ѡ=1<<11,}public class Ѡ:ь,р{public override void Ƃ(){Р=UpdateFrequency.Update10;Б=ы.ʬ.CubeGrid.
EntityId.ToString()+"-COMMAND";Ҋ=ы.Н.RegisterBroadcastListener(Б);ѝ(Ń.Ĺ,MyTuple.Create(Ӄ.ӂ,(long)0),Ѯ.ѫ,2);ѳ(MyTuple.Create(-1,
MyTuple.Create(0,(long)0),0,0));г(ї.е,(Ŗ)=>{Ŗ.È($"TASKS {Ҁ.Count}");foreach(var џ in Ҁ){Ŗ.È(џ.ĩ);}});}public override void ʝ(
UpdateFrequency è){if((è&UpdateFrequency.Update10)!=0){Ѽ++;if(Ѽ%3==0){ѷ();ѵ();ѹ();}}}public string Б{get;set;}public Ń ў{get;set;}
public А А{get;set;}public void ѝ(Ń š,MyTuple<Ӄ,long>ı,Ѯ Ҏ,int ҍ){if(Ҏ==Ѯ.ѭ){Ҁ.Clear();}if(ҁ.ContainsKey(š)){į Ҍ=ҁ[š].ĳ(š,ı,ы.
Ъ.ڛ(),ы.И,ы.ʬ.CubeGrid.EntityId);if(Ҍ is ń)return;Ҁ.Enqueue(Ҍ);}}public void ч(Д ҋ){if(ў!=Ń.Ĺ){ҋ.Б=Б;ҋ.В=ў;ҋ.А=А;if(Ҁ.
Count==0)ҋ.ł|=ł.ѥ;else ҋ.ł|=Ҁ.Peek().ł;}}IMyBroadcastListener Ҋ;Dictionary<Ń,ĵ>ҁ=new Dictionary<Ń,ĵ>();public Queue<į>Ҁ=new
Queue<į>();MyTuple<int,MyTuple<int,long>,int,int>?ѿ=null;double Ѿ;double ѽ=ә.Ӗ;int Ѽ=0;public string Ī{get;set;}public Ѡ(А ƛ)
{ы.Ъ.ڕ(this);А=ƛ;}public void ѻ(ĵ Ѻ){ў|=Ѻ.Ĵ;for(int Ŵ=0;Ŵ<30;Ŵ++){if((1<<Ŵ&(int)Ѻ.Ĵ)!=0)ҁ[(Ń)(1<<Ŵ)]=Ѻ;}Ѻ.ĳ(Ń.Ĺ,MyTuple.
Create(Ӄ.ӂ,(long)0),new Dictionary<MyTuple<Ӄ,long>,Ҿ>(),ә.Ә,0);}void ѹ(){while(true){if(Ҁ.Count==0)return;į Ѹ=Ҁ.Peek();Ѹ.Į(ы.Ъ
.ڛ(),ы.И,null);if(Ѹ.Ī==ĺ.ķ){Ҁ.Dequeue();}else if(Ѹ.Ī==ĺ.Ķ){Ҁ.Dequeue();}else{break;}}}void ѷ(){while(Ҋ.HasPendingMessage)
{var Ѷ=Ҋ.AcceptMessage();if(Ѷ.Data is MyTuple<int,MyTuple<int,long>,int,int>){ѿ=(MyTuple<int,MyTuple<int,long>,int,int>)Ѷ
.Data;Ѿ=ы.Ϲ;ѵ();}}}void ѵ(){if(Ѿ+ѽ<ы.Ϲ)ѿ=null;if(ѿ==null)return;var Ѵ=(MyTuple<int,MyTuple<int,long>,int,int>)ѿ;var ŭ=ы.Ъ
.ڛ();var ı=MyTuple.Create((Ӄ)Ѵ.Item2.Item1,Ѵ.Item2.Item2);if(!ŭ.ContainsKey(ı)&&ı.Item1!=Ӄ.ӂ)return;ѳ(Ѵ);ѿ=null;}void ѳ(
MyTuple<int,MyTuple<int,long>,int,int>Ф){if(ы.Ϲ==ә.Ә)return;ѝ((Ń)Ф.Item1,MyTuple.Create((Ӄ)Ф.Item2.Item1,Ф.Item2.Item2),(Ѯ)Ф.
Item3,Ф.Item4);}}public class Ѳ<Ç>{public List<Ç>ҩ;private int Ö;public Ѳ(List<Ç>ӥ=null){ҩ=ӥ;if(ҩ==null)ҩ=new List<Ç>();}
public Ç Ӥ(){if(Ö>=ҩ.Count){Ö=0;if(ҩ.Count==0)return default(Ç);}return ҩ[Ö++];}}public class ӣ{public string Ӣ;MyCommandLine
ӡ=new MyCommandLine();public string Ӡ;public string ӟ(Ë ˀ,int Ǥ,int ǣ){ˀ.Ã();int Ӟ=Math.Max(Ӛ-1,ǣ);for(int Ŵ=Ǥ;Ŵ<=Ӟ;++Ŵ){
ˀ.Æ(ӡ.Items[Ŵ]);if(Ŵ!=Ӟ)ˀ.Æ(' ');}return ˀ.ToString();}public bool ӝ(string Ġ){Ӡ=Ġ;bool Ӝ=ӡ.TryParse(Ġ);if(Ӝ){Ӣ=ӡ.
Argument(0);int ʟ=Ġ.IndexOf(Ӣ);Ġ=Ġ.Remove(ʟ,Ӣ.Length);Ӝ=ӡ.TryParse(Ġ);}return Ӝ;}public string ӛ(int ʟ){return ӡ.Argument(ʟ);}
public int Ӛ=>ӡ.ArgumentCount;}public static class ә{static public double Ә=0,ӗ=16.66666,Ӗ=1000;static public string ӕ=
"Monospace",Ӕ="DEBUG";static public Color ӓ=new Color(140,140,255,100),Ӓ=Color.LightBlue,Ӧ=new Color(255,140,140,100),ӑ=new Color(
255,210,180,100),ӧ=Color.White,ӹ=new Color(0.9f,0.9f,1f),Ӹ=new Color(0.7f,0.7f,1f),ӷ=Color.LightPink,Ӷ=Color.HotPink,ӵ=
Color.LightGreen;}public class Ӵ{public bool ӳ;public void Ӳ()=>ӱ(ӈ.Me);Action<IMyProgrammableBlock>ӱ;public void Ӱ(int ǘ)=>ӯ
(ӈ.Me,ǘ);Action<IMyProgrammableBlock,int>ӯ;public int Ӯ(Vector3D ĝ,Color Ҵ,float ӭ=0.2f,float ҭ=Ӊ,bool?Ҭ=null)=>Ӭ(ӈ.Me,ĝ,
Ҵ,ӭ,ҭ,Ҭ??Ӈ);Func<IMyProgrammableBlock,Vector3D,Color,float,float,bool,int>Ӭ;public int ӫ(Vector3D Ǥ,Vector3D ǣ,Color Ҵ,
float Ү=ӊ,float ҭ=Ӊ,bool?Ҭ=null)=>Ӫ(ӈ.Me,Ǥ,ǣ,Ҵ,Ү,ҭ,Ҭ??Ӈ);Func<IMyProgrammableBlock,Vector3D,Vector3D,Color,float,float,bool,
int>Ӫ;public int ө(BoundingBoxD Ө,Color Ҵ,ӎ ҳ=ӎ.ӌ,float Ү=ӊ,float ҭ=Ӊ,bool?Ҭ=null)=>Һ(ӈ.Me,Ө,Ҵ,(int)ҳ,Ү,ҭ,Ҭ??Ӈ);Func<
IMyProgrammableBlock,BoundingBoxD,Color,int,float,float,bool,int>Һ;public int ҹ(MyOrientedBoundingBoxD Ҹ,Color Ҵ,ӎ ҳ=ӎ.ӌ,float Ү=ӊ,float ҭ=Ӊ
,bool?Ҭ=null)=>ҷ(ӈ.Me,Ҹ,Ҵ,(int)ҳ,Ү,ҭ,Ҭ??Ӈ);Func<IMyProgrammableBlock,MyOrientedBoundingBoxD,Color,int,float,float,bool,
int>ҷ;public int Ҷ(BoundingSphereD ҵ,Color Ҵ,ӎ ҳ=ӎ.ӌ,float Ү=ӊ,int Ҳ=15,float ҭ=Ӊ,bool?Ҭ=null)=>ұ(ӈ.Me,ҵ,Ҵ,(int)ҳ,Ү,Ҳ,ҭ,Ҭ??
Ӈ);Func<IMyProgrammableBlock,BoundingSphereD,Color,int,float,int,float,bool,int>ұ;public int Ұ(MatrixD Č,float ү=3f,float
Ү=ӊ,float ҭ=Ӊ,bool?Ҭ=null)=>ҫ(ӈ.Me,Č,ү,Ү,ҭ,Ҭ??Ӈ);Func<IMyProgrammableBlock,MatrixD,float,float,float,bool,int>ҫ;public
int Ҫ(string Ɗ,Vector3D ĝ,Color Ҵ,float ҭ=Ӊ)=>ӏ(ӈ.Me,Ɗ,ĝ,Ҵ,ҭ);Func<IMyProgrammableBlock,string,Vector3D,Color,float,int>ӏ;
public enum ӎ{Ӎ,ӌ,Ӌ}const float ӊ=0.02f;const float Ӊ=-1;MyGridProgram ӈ;bool Ӈ;public Ӵ(MyGridProgram ж,bool ӆ=false){if(ж==
null)throw new Exception("Pass `this` into the API, not null.");Ӈ=ӆ;ӈ=ж;var Ӆ=ж.Me.GetProperty("DebugDrawAPI")?.As<
IReadOnlyDictionary<string,Delegate>>()?.GetValue(ж.Me);ӳ=(Ӆ!=null);if(ӳ){Ӑ(out ӱ,Ӆ["RemoveAll"]);Ӑ(out ӯ,Ӆ["Remove"]);Ӑ(out Ӭ,Ӆ["Point"]);
Ӑ(out Ӫ,Ӆ["Line"]);Ӑ(out Һ,Ӆ["AABB"]);Ӑ(out ҷ,Ӆ["OBB"]);Ӑ(out ұ,Ӆ["Sphere"]);Ӑ(out ҫ,Ӆ["Matrix"]);Ӑ(out ӏ,Ӆ["HUDMarker"])
;}}void Ӑ<Ç>(out Ç ɴ,object ӄ)=>ɴ=(Ç)ӄ;}[Flags]public enum Ӄ{ӂ=0,І=1,Ӂ=2,Ӏ=4,Ŀ=8,ҿ=16,}public interface Ҿ{Vector3D ҽ(
double ε);Vector3D Ҽ();float һ{get;}long ќ{get;}string Ћ{get;}Ӄ Ы{get;}string Њ();void Љ(string Ă);object Ј();MyTuple<Ӄ,long>?
Ї(object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ);}public class І:Ҿ{public Vector3D Ѕ;public Vector3D V;public Vector3D Є;public
Vector3D Ѓ;public float Ђ;public string ĩ;public static string Ё(І Ş){return
$"{Ş.Ѕ.ToString()}|{Ş.V.ToString()}|{Ş.Ђ.ToString()}|{Ş.ĩ}";}public static І Ѐ(string Ă){І Ş=new І();Ş.Љ(Ă);return Ş;}public І(){Ѕ=Vector3.One;V=Vector3.One;Ђ=-1;ĩ="Waypoint";}
public float һ=>50f;public string Ћ=>ĩ;public long ќ=>Ѕ.ToString().GetHashCode();public Ӄ Ы=>Ӄ.І;public Vector3D ҽ(double ε){
return Ѕ;}public Vector3D Ҽ(){return Vector3.Zero;}public string Њ(){return Ё(this);}public void Љ(string Ă){string[]ě=Ă.Split
('|');Vector3D.TryParse(ě[0],out Ѕ);Vector3D.TryParse(ě[1],out V);Vector3D.TryParse(ě[2],out Є);Ђ=float.Parse(ě[3]);ĩ=ě[4
];}public object Ј(){return MyTuple.Create((int)Ы,ќ,MyTuple.Create(Ѕ,V,Є,Ђ,ĩ));}static public І ϧ(object Ϥ){var ϣ=(
MyTuple<Vector3D,Vector3D,Vector3D,float,string>)Ϥ;var Ş=new І();Ş.ϥ(ϣ);return Ş;}public void ϥ(MyTuple<Vector3D,Vector3D,
Vector3D,float,string>ϣ){Ѕ=ϣ.Item1;V=ϣ.Item2;Є=ϣ.Item3;Ђ=ϣ.Item4;ĩ=ϣ.Item5;}public MyTuple<Ӄ,long>?Ї(object Ϥ,Dictionary<MyTuple
<Ӄ,long>,Ҿ>ŭ){var ϣ=(MyTuple<int,long,MyTuple<Vector3D,Vector3D,Vector3D,float,string>>)Ϥ;var N=MyTuple.Create((Ӄ)ϣ.Item1
,ϣ.Item2);if(ŭ!=null&&N.Item1==Ӄ.І){if(ŭ.ContainsKey(N))((І)ŭ[N]).ϥ(ϣ.Item3);else ŭ.Add(N,І.ϧ(ϣ.Item3));return N;}return
null;}}public class Д:Ҿ{public float һ{get;set;}public long ќ{get;set;}public string Ћ{get;set;}public Ӄ Ы=>Ӄ.Ӏ;public void
Љ(string Ă){}public string Њ(){return string.Empty;}public Vector3D ҽ(double ε){return Г+ϰ*((ε-ϯ)/ә.Ӗ);}public Vector3D Ҽ
(){return ϰ;}public Vector3D ϰ;public Vector3D Г;public double ϯ;public Ń В;public string Б;public А А;public ł ł;public
Vector3I Џ=Vector3I.Zero;public long Е=0;public Ϝ Ϝ=Ϝ.Ĺ;public int Ў=0;public object Ј(){return MyTuple.Create((int)Ы,ќ,MyTuple.
Create(MyTuple.Create(Г,ϰ,ϯ),MyTuple.Create(Ћ,ќ,һ,Ў),MyTuple.Create((int)В,Б,(int)А,(int)ł,Џ),MyTuple.Create(Е,(int)Ϝ)));}
public MyTuple<Ӄ,long>?Ї(object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){var ϣ=(MyTuple<int,long,MyTuple<MyTuple<Vector3D,Vector3D,
double>,MyTuple<string,long,float,int>,MyTuple<int,string,int,int,Vector3I>,MyTuple<long,int>>>)Ϥ;var N=MyTuple.Create((Ӄ)ϣ.
Item1,ϣ.Item2);if(ŭ!=null&&N.Item1==Ӄ.Ӏ){if(ŭ.ContainsKey(N))((Д)ŭ[N]).ϥ(ϣ.Item3);else ŭ.Add(N,Д.ϧ(ϣ.Item3));return N;}return
null;}static public Д ϧ(object Ϥ){var ϣ=(MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple<string,long,float,int>,MyTuple<
int,string,int,int,Vector3I>,MyTuple<long,int>>)Ϥ;var ǡ=new Д();ǡ.ϥ(ϣ);return ǡ;}public void ϥ(MyTuple<MyTuple<Vector3D,
Vector3D,double>,MyTuple<string,long,float,int>,MyTuple<int,string,int,int,Vector3I>,MyTuple<long,int>>ϣ){Г=ϣ.Item1.Item1;ϰ=ϣ.
Item1.Item2;ϯ=ϣ.Item1.Item3;Ћ=ϣ.Item2.Item1;ќ=ϣ.Item2.Item2;һ=ϣ.Item2.Item3;Ў=ϣ.Item2.Item4;В=(Ń)ϣ.Item3.Item1;Б=ϣ.Item3.
Item2;А=(А)ϣ.Item3.Item3;ł=(ł)ϣ.Item3.Item4;Џ=ϣ.Item3.Item5;Е=ϣ.Item4.Item1;Ϝ=(Ϝ)ϣ.Item4.Item2;}}public class Ѝ:Ҿ{public
Vector3D Ѕ;public static string Ќ(Ѝ Ϧ){return$"{Ϧ.Ѕ.ToString()}|{Ϧ.һ}|{Ϧ.ќ}";}public static Ѝ ϩ(string Ă){Ѝ Ϧ=new Ѝ();Ϧ.Љ(Ă);
return Ϧ;}public float һ{get;set;}public string Ћ=>"Asteroid";public long ќ{get;set;}public Ӄ Ы=>Ӄ.Ӂ;public Vector3D ҽ(double
ε){return Ѕ;}public Vector3D Ҽ(){return Vector3.Zero;}public string Њ(){return Ќ(this);}public void Љ(string Ă){string[]ě
=Ă.Split('|');Vector3D.TryParse(ě[0],out Ѕ);һ=float.Parse(ě[1]);ќ=long.Parse(ě[2]);}public object Ј(){return MyTuple.
Create((int)Ы,ќ,MyTuple.Create(Ѕ,һ,ќ));}static public Ѝ ϧ(object Ϥ){var ϣ=(MyTuple<Vector3D,float,long>)Ϥ;var Ϧ=new Ѝ();Ϧ.ϥ(ϣ)
;return Ϧ;}public void ϥ(MyTuple<Vector3D,float,long>ϣ){Ѕ=ϣ.Item1;һ=ϣ.Item2;ќ=ϣ.Item3;}public MyTuple<Ӄ,long>?Ї(object Ϥ,
Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){var ϣ=(MyTuple<int,long,MyTuple<Vector3D,float,long>>)Ϥ;var N=MyTuple.Create((Ӄ)ϣ.Item1,ϣ.Item2);
if(ŭ!=null&&N.Item1==Ӄ.Ӂ){if(ŭ.ContainsKey(N))((Ѝ)ŭ[N]).ϥ(ϣ.Item3);else ŭ.Add(N,Ѝ.ϧ(ϣ.Item3));return N;}return null;}}
public enum Ϣ{Ĺ=0,ϡ=1<<0,Ϡ=1<<1,ϟ=1<<2,Ϟ=1<<3,ϝ=1<<4,}[Flags]public enum Ϝ{Ĺ=0,ϛ=1<<0,Ϛ=1<<1,ϙ=1<<2,Ϙ=1<<3,Ϩ=1<<4,Ϫ=1<<5,Ͼ=1<<
6,Ͽ=1<<7,Ͻ=1<<8,ϼ=1<<9,ϻ=1<<10,}public class Ϻ{public double Ϲ;public Dictionary<long,double>ϸ=new Dictionary<long,double
>();public Dictionary<string,string[]>Ϸ=new Dictionary<string,string[]>();}public class ϵ:Ҿ{public float һ=>0;public long
ќ{get;set;}public string Ћ{get;set;}public Ӄ Ы=>Ӄ.Ŀ;public void Љ(string Ă){}public Vector3D ҽ(double ε){return ϴ.
Translation+ϰ*((ε-ϯ)/ә.Ӗ);}public Vector3D Ҽ(){return ϰ;}public string Њ(){return string.Empty;}public MatrixD ϴ;public float ϳ=20;
public float ϲ=1.5f;public Vector3D ϱ;public Vector3D ϰ;public double ϯ;public long Ϯ;public Ϣ Ī;public Ϝ ϭ;public string Ϭ;
public object Ј(){return MyTuple.Create((int)Ы,ќ,MyTuple.Create(MyTuple.Create(ϴ,ϳ,ϲ,ϰ,ϯ,ϱ),MyTuple.Create(Ϯ,(int)Ī,(int)ϭ,Ϭ),
MyTuple.Create(ќ,Ћ)));}static public ϵ ϧ(object Ϥ){var ϣ=(MyTuple<MyTuple<MatrixD,float,float,Vector3D,double,Vector3D>,MyTuple
<long,int,int,string>,MyTuple<long,string>>)Ϥ;var ϫ=new ϵ();ϫ.ϥ(ϣ);return ϫ;}public void ϥ(MyTuple<MyTuple<MatrixD,float,
float,Vector3D,double,Vector3D>,MyTuple<long,int,int,string>,MyTuple<long,string>>ϣ){ϴ=ϣ.Item1.Item1;ϳ=ϣ.Item1.Item2;ϲ=ϣ.
Item1.Item3;ϰ=ϣ.Item1.Item4;ϯ=ϣ.Item1.Item5;ϱ=ϣ.Item1.Item6;Ϯ=ϣ.Item2.Item1;Ī=(Ϣ)ϣ.Item2.Item2;ϭ=(Ϝ)ϣ.Item2.Item3;Ϭ=ϣ.Item2.
Item4;ќ=ϣ.Item3.Item1;Ћ=ϣ.Item3.Item2;}public MyTuple<Ӄ,long>?Ї(object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){var ϣ=(MyTuple<int,
long,MyTuple<MyTuple<MatrixD,float,float,Vector3D,double,Vector3D>,MyTuple<long,int,int,string>,MyTuple<long,string>>>)Ϥ;var
N=MyTuple.Create((Ӄ)ϣ.Item1,ϣ.Item2);if(ŭ!=null&&N.Item1==Ӄ.Ŀ){if(ŭ.ContainsKey(N))((ϵ)ŭ[N]).ϥ(ϣ.Item3);else ŭ.Add(N,ϧ(ϣ.
Item3));return N;}return null;}static public bool ц(Ϝ Ü,Ϝ å){return(Ü==0||å==0||(Ü&å)!=0);}}public class х:Ҿ{public float һ{
get;set;}public long ќ{get;set;}public string Ћ{get;set;}public Ӄ Ы=>Ӄ.ҿ;public void Љ(string Ă){}public Vector3D ҽ(double
ε){return Г+ϰ*((ε-ϯ)/ә.Ӗ);}public Vector3D Ҽ(){return ϰ;}public string Њ(){return string.Empty;}public Vector3D ϰ;public
Vector3D Г;public double ϯ;public MyCubeSize ф;public object Ј(){return MyTuple.Create((int)Ы,ќ,MyTuple.Create(MyTuple.Create(Г,
ϰ,ϯ),MyTuple.Create(Ћ,ќ,һ,(int)ф)));}static public х ϧ(object Ϥ){var ϣ=(MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple
<string,long,float,int>>)Ϥ;var Ɖ=new х();Ɖ.ϥ(ϣ);return Ɖ;}public void ϥ(MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple
<string,long,float,int>>ϣ){Г=ϣ.Item1.Item1;ϰ=ϣ.Item1.Item2;ϯ=ϣ.Item1.Item3;Ћ=ϣ.Item2.Item1;ќ=ϣ.Item2.Item2;һ=ϣ.Item2.
Item3;ф=(MyCubeSize)ϣ.Item2.Item4;}public MyTuple<Ӄ,long>?Ї(object Ϥ,Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){var ϣ=(MyTuple<int,long,
MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple<string,long,float,int>>>)Ϥ;var N=MyTuple.Create((Ӄ)ϣ.Item1,ϣ.Item2);if(ŭ!=
null&&N.Item1==Ӄ.ҿ){if(ŭ.ContainsKey(N))((х)ŭ[N]).ϥ(ϣ.Item3);else ŭ.Add(N,ϧ(ϣ.Item3));return N;}return null;}static public
bool у(х m){if(m.ф==MyCubeSize.Small&&m.һ<4)return false;if(m.ф==MyCubeSize.Large&&m.һ<8)return false;return true;}public
void т(MyDetectedEntityInfo Z,double Ĭ){if(Z.Type!=MyDetectedEntityType.SmallGrid&&Z.Type!=MyDetectedEntityType.LargeGrid&&Z
.Type!=MyDetectedEntityType.Unknown)throw new Exception("Type="+Z.Type.ToString());if(Z.Relationship!=
MyRelationsBetweenPlayerAndBlock.Enemies&&Z.Relationship!=MyRelationsBetweenPlayerAndBlock.Neutral&&Z.Relationship!=MyRelationsBetweenPlayerAndBlock.
NoOwnership)throw new Exception("Relations="+Z.Relationship.ToString());if(ќ!=Z.EntityId){if(Z.Type!=MyDetectedEntityType.Unknown){
ф=Z.Type==MyDetectedEntityType.SmallGrid?MyCubeSize.Small:MyCubeSize.Large;ќ=Z.EntityId;}else throw new Exception();}һ=(
float)Z.BoundingBox.Size.Length()*0.5f;if(string.IsNullOrEmpty(Ћ)){Ћ=Z.Name!=null?Z.Name:"null";}Г=Z.BoundingBox.Center;ϰ=Z.
Velocity;ϯ=Ĭ;}}public enum м{е,с,Ĺ}public interface р{void ч(Д ª);}public class њ{public ӽ љ=new ӽ();public Ӵ ј;public њ(П ы){ј=
new Ӵ(ы.О);if(!ј.ӳ)ј=null;}}public enum ї{е=0,і=1,ѕ=2,є=3,ѓ=4,Ĺ=-1,}public class ђ{Action<Ë>ћ;Ë ū=new Ë();public bool ѐ;
public ђ(Action<Ë>я){ћ=я;}public bool ʝ(){if(ѐ){ū.Ã();ћ.Invoke(ū);ѐ=false;return true;}return false;}static public string ю(ђ
Ц){if(Ц==null)return"";Ц.ʝ();return Ц.ū.ToString();}static public void э(ђ Ц,Ë ˀ){if(Ц!=null){Ц.ʝ();ˀ.Æ(Ц.ū.ToString());}
}}public abstract class ь{public П ы;public Dictionary<string,Action<ӣ>>ъ=new Dictionary<string,Action<ӣ>>();public ђ[]щ=
new ђ[(int)ї.ѓ];public bool ш;public ђ ё(ї Ч){return щ[(int)Ч];}public void г(ї Ч,Action<Ë>Щ){щ[(int)Ч]=new ђ(Щ);}public
void Ш(ї Ч){var Ц=ё(Ч);if(Ц!=null)Ц.ѐ=true;ш=true;}public abstract void Ƃ();public abstract void ʝ(UpdateFrequency è);public
virtual void Х(ӣ Ф){}public virtual string У(){return string.Empty;}public virtual void Т(string С){}public UpdateFrequency Р=
UpdateFrequency.Update1;}public class П{public MyGridProgram О;public IMyIntergridCommunicationSystem Н;public IMyGridTerminalSystem ϊ;
public IMyTerminalBlock ʬ;public Ë М=new Ë(256);public Random Л=new Random();public long К=0;public double Ϲ=0;public long Й=0
;public double И=0;public ɫ З=null;public IMyShipController Φ;public څ Ъ;public Dictionary<string,ь>Ж=new Dictionary<
string,ь>(StringComparer.OrdinalIgnoreCase);public Dictionary<long,double>ϸ=new Dictionary<long,double>();IMyBroadcastListener
п;const string н="[FLT-GNR]";м м=м.Ĺ;bool ϋ=true;public ӣ л=new ӣ();Ë к=new Ë();Ë й=new Ë();Ë и=new Ë();ƿ з;public П(
MyGridProgram ж,IMyTerminalBlock č=null){О=ж;Н=ж.IGC;ϊ=ж.GridTerminalSystem;ʬ=(č==null)?ж.Me:č;е=new њ(this);ê();if(м==м.с)з=new ƿ(О.
Runtime);п=Н.RegisterBroadcastListener(н);ɫ.ɡ(ʬ,ref З);}public њ е=null;void ê(){using(ڰ о=new ڰ()){if(о.ڬ(ʬ)){var д="Manager";
м в;if(Enum.TryParse(о.ډ(д,"OutputMode",""),out в))м=в;}}}public void б(string Ɗ,ь Я){Ж[Ɗ]=Я;Я.ы=this;څ ª=Я as څ;if(ª!=
null)Ъ=ª;}public Ç а<Ç>()where Ç:class{foreach(var t in Ж){Ç Я=t.Value as Ç;if(Я!=null)return Я;}return null;}public void Ю(
){if(м==м.с)з.Ú("Initialize");foreach(var t in Ж)t.Value.Ƃ();if(м==м.с)з.Ù("Initialize");}void ɡ(){Ю();ϋ=true;}public
string Э(){Ë ѱ=new Ë();ѱ.È(Ж.Count.ToString());foreach(var t in Ж){string ح=t.Value.У();int ن=ح.Split(new[]{"\r\n","\r","\n"},
StringSplitOptions.None).Length;ѱ.È($"{t.Key} {ن.ToString()}");ѱ.È(ح);}return ѱ.ToString();}public void م(string С){try{var ل=new Ë();var
ك=new Á(С);ل.Ã();int ق=int.Parse(ك.ñ());for(int Ŵ=0;Ŵ<ق;Ŵ++){string[]ف=ك.ñ().Split(' ');string Ɗ=ف[0];int ـ=int.Parse(ف[1
]);for(int ؿ=0;ؿ<ـ;ؿ++){ل.È(ك.ñ());}if(Ж.ContainsKey(Ɗ)){Ж[Ɗ].Т(ل.ToString());}ل.Ã();}}catch(Exception exc){и.È(exc.
StackTrace);}}void ؾ(){Ϲ+=О.Runtime.TimeSinceLastRun.TotalMilliseconds;Й=(long)Ϲ;И=Ϲ+(Ъ!=null?Ъ.ژ:ә.Ә);К++;}void ؽ(){foreach(var t
in Ж){var Я=t.Value;for(int Ŵ=0;Ŵ<(int)ї.ѓ;++Ŵ){if(Я.щ[Ŵ]!=null)Я.ш|=Я.щ[Ŵ].ʝ();}}}public void ʝ(string Қ,UpdateType ҙ){if
(л.ӝ(Қ)){ؾ();Х(л);ؽ();}else if(ϋ){ؾ();if(К%1000==0&&З==null)ɫ.ɡ(ʬ,ref З);while(п.HasPendingMessage){var Ѷ=п.AcceptMessage
();var Ϥ=Ѷ.Data.ToString();if(л.ӝ(Ϥ)){Х(л);}}if(м==м.с)з.Ú("Setup frequencies");if(м==м.с)з.ß();UpdateFrequency ؼ=
UpdateFrequency.None;if((ҙ&UpdateType.Update1)!=0)ؼ|=UpdateFrequency.Update1;if((ҙ&UpdateType.Update10)!=0)ؼ|=UpdateFrequency.Update10;
if((ҙ&UpdateType.Update100)!=0)ؼ|=UpdateFrequency.Update100;UpdateFrequency ػ=UpdateFrequency.Update1;if(м==м.с)з.Ù(
"Setup frequencies");foreach(var Я in Ж){if(м==м.с)з.Ú(Я.Key);ь غ=Я.Value;if((غ.Р&ؼ)!=0){غ.ʝ(ؼ);}ػ|=غ.Р;if(м==м.с)з.Ù(Я.Key);}О.Runtime.
UpdateFrequency=ػ;ؽ();var ع=ټ();if(ع!=string.Empty)О.Echo(ع);}}public void ظ(ї Ч,Ë ˀ){foreach(var t in Ж){ђ.э(t.Value.ё(Ч),ˀ);}Ϻ ª;if(Ъ
.ڍ.TryGetValue(ʬ.EntityId,out ª)){foreach(var t in ª.Ϸ){if(Ж.ContainsKey(t.Key))continue;var ٽ=t.Value[(int)Ч];if(!String
.IsNullOrEmpty(ٽ))ˀ.Æ(ٽ);}}}public string ټ(){к.Ã();к.È($"OUTPUT MODE: {(int)м}");if(м==м.с){з.Ú("Profiler");з.Û(к);к.È(
"============");з.Ô(к);з.Ù("Profiler");}else if(м==м.е){к.È(и.ToString());к.È("=====");к.Æ("Cycle ").È(К.ToString());к.Æ(Ж.Count.
ToString()).È(" systems connected");foreach(var t in Ж){var Я=t.Value;Я.Ш(ї.е);к.È("["+t.Key+"]");ђ.э(Я.ё(ї.е),к);}е.љ.э(й);к.È(
й.ToString());й.Ã();}else return string.Empty;return к.ToString();}public void Х(ӣ Ф){е.љ.е("COM: "+Ф.Ӡ);if(Ф.Ӣ==
"manager"){if(Ф.ӛ(0)=="reset")Ю();if(Ф.ӛ(0)=="broadcast")Н.SendBroadcastMessage(н,Ф.ӟ(М,1,Ф.Ӛ-1));return;}else if(Ф.Ӣ!=null){ь Я;
if(Ж.TryGetValue(Ф.Ӣ,out Я)){var ٻ=Ф.ӛ(0);if(Я.ъ.ContainsKey(ٻ)){Я.ъ[ٻ].Invoke(Ф);е.љ.е(" *OK* ");return;}}}е.љ.е(
" *FAILED* ");}}public enum ٺ{ٹ,ص,ٸ,ٷ,پ,}public class ٶ{List<IMyDoor>ٴ=new List<IMyDoor>();List<IMyInteriorLight>ٳ=new List<
IMyInteriorLight>();IMyTextPanel ٲ;public IMyShipConnector ʥ;public IMyInteriorLight ٱ;public Ϣ ٯ=Ϣ.Ĺ;public long Ϯ=-1;public ϵ ٮ=new ϵ(
);public int ʡ=0;public خ ƅ;double ي;double ى;double و=3000;double ه=3000;List<int>ٵ=new List<int>();public float ط=40;
public Ϝ Ϝ=Ϝ.Ĺ;bool ت=false;public ٶ(int ʟ,خ ʖ){ʡ=ʟ;ƅ=ʖ;}public void Ω(IMyTerminalBlock ɲ){if(ŕ.ŉ(ref ʥ,ɲ,""))ة();ŕ.ŉ(ٴ,ɲ,"");
ŕ.ŉ(ref ٲ,ɲ,"");if(!ŕ.ŉ(ref ٱ,ɲ,"[DI]",(ˢ)=>{ٱ.Color=Color.Red;ٱ.Intensity=0.5f;ٱ.BlinkIntervalSeconds=1;ٱ.BlinkLength=
0.1f;return true;}))ŕ.ŉ(ٳ,ɲ,"",(ˢ)=>{ˢ.Intensity=2f;ˢ.Radius=12f;return true;});}void ة(){ٵ.Clear();using(ڰ é=new ڰ()){if(é.
ڬ(ʥ)){var ب=é.ډ("Hangar","Mutex","");if(ب!=string.Empty){var ě=ب.Split(',');foreach(var Ŵ in ě){int ʟ;if(int.TryParse(Ŵ,
out ʟ))ٵ.Add(ʟ);}}ط=é.ڪ("Hangar","ClearanceDist",ط);var ا=é.ډ("Hangar","Tags","");if(ا.Contains("A"))Ϝ|=Ϝ.ϛ;if(ا.Contains(
"B"))Ϝ|=Ϝ.Ϛ;if(ا.Contains("C"))Ϝ|=Ϝ.ϙ;if(ا.Contains("D"))Ϝ|=Ϝ.Ϙ;if(ا.Contains("E"))Ϝ|=Ϝ.Ϩ;if(ا.Contains("F"))Ϝ|=Ϝ.Ϫ;if(ا.
Contains("G"))Ϝ|=Ϝ.Ͼ;if(ا.Contains("H"))Ϝ|=Ϝ.Ͽ;if(ا.Contains("I"))Ϝ|=Ϝ.Ͻ;if(ا.Contains("J"))Ϝ|=Ϝ.ϼ;}}}public void Ã(){ʥ=null;ٱ=
null;ٴ.Clear();ٳ.Clear();ٲ=null;Ϯ=0;ٯ=Ϣ.Ĺ;}public void ئ(long إ,ٺ ؤ){if(ؤ==ٺ.ٹ){if(Ϯ!=-1&&Ϯ!=إ)return;ج(إ);ث();}else if(ؤ==ٺ
.ٸ){if(Ϯ!=-1&&Ϯ!=إ)return;ج(إ);ٯ|=Ϣ.Ϡ;}else if(ؤ==ٺ.ص){if(Ϯ!=إ)return;ص();}else if(ؤ==ٺ.پ){ى=ƅ.ы.Ϲ;ױ();}}bool أ(){bool ˬ=
true;foreach(var ʟ in ٵ){if(ƅ.ڟ[ʟ]==null)continue;if((ƅ.ڟ[ʟ].ٯ&(Ϣ.Ϟ|Ϣ.ϝ))==0)continue;ˬ=false;}foreach(var آ in ٴ){if(آ.
Status==DoorStatus.Open)continue;ˬ=false;}return ˬ;}void ء(){foreach(var ײ in ٴ){if(ײ.Status!=DoorStatus.Opening&&ײ.Status!=
DoorStatus.Open)ײ.OpenDoor();}}void ؠ(){foreach(var ײ in ٴ){if(ײ.Status!=DoorStatus.Closed&&ײ.Status!=DoorStatus.Closing)ײ.
CloseDoor();}}void ث(){ء();if(أ())ٯ|=Ϣ.Ϟ;}void ױ(){ء();if(أ())ٯ|=Ϣ.ϝ;}void ج(long إ){Ϯ=إ;ي=ƅ.ы.Ϲ;}void ص(){ٯ&=~Ϣ.Ϡ;}public void ʝ
(Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){if(ʥ==null)return;if(!ت){ت=true;if(ʥ.Status==MyShipConnectorStatus.Connected){ٯ|=Ϣ.Ϡ;Ϯ=ʥ
.OtherConnector.CubeGrid.EntityId;}}ش(ŭ);}void ش(Dictionary<MyTuple<Ӄ,long>,Ҿ>ŭ){var س=ƅ.ы.Ϲ;bool ز=ي+و<س;bool ر=ى+ه<س;if
((ٯ&Ϣ.Ϡ)==0){if(ز&&ʥ.Status!=MyShipConnectorStatus.Connected)Ϯ=-1;}else{if(Ϯ==-1){ص();}else if(ز&&ʥ.Status!=
MyShipConnectorStatus.Connected){var ı=MyTuple.Create(Ӄ.Ӏ,Ϯ);if(!ŭ.ContainsKey(ı)){ص();return;}if(((Д)ŭ[ı]).Е!=ʥ.EntityId){ص();}}}if(ز){if((ٯ
&Ϣ.Ϟ)!=0){ؠ();ٯ&=~Ϣ.Ϟ;}}if(ر){if((ٯ&Ϣ.ϝ)!=0){ؠ();ٯ&=~Ϣ.ϝ;}}if((ٯ&(Ϣ.Ϟ|Ϣ.ϝ))!=0)ذ(Color.Yellow);else if(!أ())ذ(Color.Red);
else ذ(Color.Green);}void ذ(Color Ҵ){foreach(var ˢ in ٳ){ˢ.Color=Ҵ;}}public void د(){if(ٲ==null)return;var ض=ƅ.ы.М;ض.Ã();ض.È
("Exclusive with:");foreach(int Ŵ in ٵ)ض.Æ(Ŵ).Æ(' ');ض.È(((int)ٯ).ToString());ض.È(((int)Ϝ).ToString());ٲ.WriteText(ض.
ToString());}public string Њ(){return$"{(int)ٯ}|{Ϯ}";}public void Љ(string С){var ě=С.Split('|');ٯ=(Ϣ)int.Parse(ě[0]);Ϯ=long.
Parse(ě[1]);}}public class خ:ь{public خ(string ò="H"){Τ=ò;ý="["+ò;Р=UpdateFrequency.Update10|UpdateFrequency.Update100;}
public override void Ƃ(){ъ["clear"]=(î)=>{var ˣ=î.ӛ(1);ڴ(ˣ);};í();Ϭ=ы.ʬ.CubeGrid.EntityId.ToString()+"-HANGAR";ڢ=ы.Н.
RegisterBroadcastListener(Ϭ);г(ї.і,(Ŗ)=>{var ŭ=ы.Ъ.ڛ();Ŗ.È("     |H |P |A |ST  |");foreach(var Ŭ in ڠ){Ŗ.Æ('H').Æ(Ŭ.ʡ.ToString("00")).Æ(":");if(Ŭ
.Ϯ==-1){Ŗ.È("|EMPTY         ");}else{var N=MyTuple.Create(Ӄ.Ӏ,Ŭ.Ϯ);if(ŭ.ContainsKey(N)){var ǡ=(Д)ŭ[N];if(ǡ.А==А.ѩ){Ŗ.Æ(
'|').Æ(ǡ.Џ.X==100?"99":ǡ.Џ.X.ToString("00"));Ŗ.Æ('|').Æ(ǡ.Џ.Y==100?"99":ǡ.Џ.Y.ToString("00"));Ŗ.Æ('|').Æ(ǡ.Џ.Z==100?"99":ǡ.
Џ.Z.ToString("00"));var ٿ="|AWAY|";if((ǡ.ł&ł.Ѥ)!=0&&ǡ.Џ.X<95)ٿ="|RFUL|";else if((ǡ.ł&ł.Ѥ)!=0&&ǡ.Џ.Y<20)ٿ="|RCHG|";else if
((ǡ.ł&ł.Ѥ)!=0&&ǡ.Џ.Z<50)ٿ="|RELD|";else if((ǡ.ł&ł.Ѥ)!=0)ٿ="|REDY|";else if((ǡ.ł&ł.Ѣ)!=0)ٿ="|ENGE|";else if((ǡ.ł&ł.ѡ)!=0)ٿ
="|RTRN|";Ŗ.È(ٿ);continue;}}Ŗ.È("|OCCUPIED      ");}}});}public override void Т(string С){var ك=new Á(С);while(ك.µ){var ě
=ك.ñ().Split('-');if(ě.Length!=2)continue;var օ=int.Parse(ě[0]);if(ڟ[օ]==null)continue;ڟ[օ].Љ(ě[1]);}}public override
string У(){var ѱ=ы.М;ѱ.Ã();for(int Ŵ=0;Ŵ<ڟ.Length;Ŵ++){if(ڟ[Ŵ]!=null){ѱ.È($"{Ŵ}-{ڟ[Ŵ].Њ()}");}}return ѱ.ToString();}public
override void ʝ(UpdateFrequency è){if((è&UpdateFrequency.Update10)!=0){ڳ();ڲ();}else if((è&UpdateFrequency.Update100)!=0){ڵ();}}
public bool ڧ(){return ڥ;}public void ڦ(){ڥ=false;}bool ڥ=false;Dictionary<ٶ,MyShipConnectorStatus>ڤ=new Dictionary<ٶ,
MyShipConnectorStatus>();void ڣ(){}string Τ;string ý;string Ϭ;IMyBroadcastListener ڢ;IMyShipController Ԡ;IMyInteriorLight ٱ;public Dictionary
<long,ٶ>ڡ=new Dictionary<long,ٶ>(64);public List<ٶ>ڠ=new List<ٶ>();public ٶ[]ڟ=new ٶ[64];void í(){Ԡ=null;ٱ=null;foreach(
var Ŭ in ڟ)Ŭ?.Ã();ڡ.Clear();ڤ.Clear();ڠ.Clear();ы.ϊ.GetBlocksOfType<IMyTerminalBlock>(null,ς);foreach(var Ŭ in ڟ){if(ڱ(Ŭ)){
ڠ.Add(Ŭ);ڡ[Ŭ.ʥ.EntityId]=Ŭ;}}}bool ς(IMyTerminalBlock đ){if(!ы.ʬ.IsSameConstructAs(đ))return false;if(đ is
IMyShipController){Ԡ=(IMyShipController)đ;return false;}var ρ=đ.CustomName.IndexOf(ý);if(ρ==-1)return false;var ʚ=đ.CustomName.IndexOf(
']',ρ);if(ʚ==-1)return false;var ʙ=đ.CustomName.Substring(ρ+ý.Length,ʚ-ρ-ý.Length);if(ʙ==string.Empty){if(đ is
IMyInteriorLight&&đ.CustomName.Contains("[DI]"))ٱ=(IMyInteriorLight)đ;return false;}int ڨ;if(!int.TryParse(ʙ,out ڨ))return false;if(ڟ[ڨ]
==null)ڟ[ڨ]=new ٶ(ڨ,this);ڟ[ڨ].Ω(đ);return false;}ϵ ڞ(ٶ Ŭ){var ˀ=ы.М;ˀ.Ã();Ŭ.ٮ.ϴ=Ŭ.ʥ.WorldMatrix;Ŭ.ٮ.ϰ=Ԡ.GetShipVelocities
().LinearVelocity;Ŭ.ٮ.Ī=Ŭ.ٯ;Ŭ.ٮ.Ϯ=Ŭ.Ϯ;Ŭ.ٮ.ϯ=ы.И;Ŭ.ٮ.ќ=Ŭ.ʥ.EntityId;if(string.IsNullOrEmpty(Ŭ.ٮ.Ћ)){Ŭ.ٮ.Ћ=ˀ.Æ(Ŭ.ʥ.
CustomName).Æ(" - ").Æ(ы.ʬ.CubeGrid.CustomName).ToString();}Ŭ.ٮ.ϲ=Ŭ.ʥ.CubeGrid.GridSizeEnum==MyCubeSize.Large?1.3f:0.55f;Ŭ.ٮ.ϳ=Ŭ.ط
;Ŭ.ٮ.ϱ=Ŭ.ٱ==null?(ٱ==null?Vector3D.Zero:ٱ.WorldMatrix.Forward):Ŭ.ٱ.WorldMatrix.Forward;Ŭ.ٮ.Ϭ=Ϭ;Ŭ.ٮ.ϭ=Ŭ.Ϝ;return Ŭ.ٮ;}void
ڴ(object Қ){if(Қ==null){foreach(var Ŭ in ڟ){if(ڱ(Ŭ)){Ŭ.Ϯ=-1;}}}else if(Қ is string){int ʟ;if(int.TryParse((string)Қ,out ʟ
)){ڟ[ʟ].Ϯ=-1;}}}void ڳ(){var ŭ=ы.Ъ.ڛ();foreach(var Ŭ in ڟ){if(ڱ(Ŭ)){ы.Ъ.ڙ(ڞ(Ŭ));Ŭ.ʝ(ŭ);if(ڥ==false&&ڤ.ContainsKey(Ŭ)&&((ڤ
[Ŭ]==MyShipConnectorStatus.Connected&&Ŭ.ʥ.Status!=MyShipConnectorStatus.Connected)||(ڤ[Ŭ]!=MyShipConnectorStatus.
Connected&&Ŭ.ʥ.Status==MyShipConnectorStatus.Connected))){ڥ=true;}ڤ[Ŭ]=Ŭ.ʥ.Status;}}}void ڲ(){while(ڢ.HasPendingMessage){var Ϥ=ڢ.
AcceptMessage().Data;if(!(Ϥ is MyTuple<long,long,int>))return;var ϣ=(MyTuple<long,long,int>)Ϥ;ٶ Ŭ;if(!ڡ.TryGetValue(ϣ.Item2,out Ŭ))
return;Ŭ.ئ(ϣ.Item1,(ٺ)ϣ.Item3);}}bool ڱ(ٶ Ŭ){return Ŭ!=null&&Ŭ.ʥ!=null;}void ڵ(){foreach(var Ŭ in ڟ){if(ڱ(Ŭ))Ŭ.د();}}}public
class ڰ:IDisposable{static List<MyIni>گ=new List<MyIni>();static int ڮ=0;MyIni ڭ;public ڰ(){++ڮ;if(گ.Count<ڮ)گ.Add(new MyIni(
));ڭ=گ[گ.Count-1];ڭ.Clear();}public bool ڬ(IMyTerminalBlock đ){return ڭ.TryParse(đ.CustomData);}public bool ګ(string ڈ){
return ڭ.ContainsSection(ڈ);}public float ڪ(string ڈ,string ڇ,float چ=0){return ڭ.Get(ڈ,ڇ).ToSingle(چ);}public double ک(string
ڈ,string ڇ,double چ=0){return ڭ.Get(ڈ,ڇ).ToDouble(چ);}public int ڋ(string ڈ,string ڇ,int چ=0){return ڭ.Get(ڈ,ڇ).ToInt32(چ
);}public bool ڊ(string ڈ,string ڇ,bool چ=false){return ڭ.Get(ڈ,ڇ).ToBoolean(چ);}public string ډ(string ڈ,string ڇ,string
چ){return ڭ.Get(ڈ,ڇ).ToString(چ);}public void Dispose(){ڮ--;}}public class څ:ь{public override void Т(string С){if(ԗ){Á ك
=new Á(С);while(ك.µ){var Ă=ك.ñ();if(Ă==string.Empty)return;ڙ(Ѝ.ϩ(Ă));}}}public override string У(){if(ԗ){var ѱ=ы.М;ѱ.Ã();
foreach(var t in ĭ){if(t.Key.Item1==Ӄ.Ӂ){ѱ.È(t.Value.Њ());}}return ѱ.ToString();}return string.Empty;}public override void Ƃ(){
if(ƅ==null){Ԝ.Add(new Ґ.ң<І,MyTuple<int,long,MyTuple<Vector3D,Vector3D,Vector3D,float,string>>>());Ԝ.Add(new Ґ.ң<Ѝ,MyTuple
<int,long,MyTuple<Vector3D,float,long>>>());Ԝ.Add(new Ґ.ң<Д,MyTuple<int,long,MyTuple<MyTuple<Vector3D,Vector3D,double>,
MyTuple<string,long,float,int>,MyTuple<int,string,int,int,Vector3I>,MyTuple<long,int>>>>());Ԝ.Add(new Ґ.ң<ϵ,MyTuple<int,long,
MyTuple<MyTuple<MatrixD,float,float,Vector3D,double,Vector3D>,MyTuple<long,int,int,string>,MyTuple<long,string>>>>());Ԝ.Add(new
Ґ.ң<х,MyTuple<int,long,MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple<string,long,float,int>>>>());foreach(var Ԇ in Ԝ)
{Ԇ.Ғ(ы,123,ĭ,ref ڎ,Ԥ);Ԇ.Ҕ(ы,123,ĭ,Ԥ);Ԇ.җ();}ԥ();ڛ();ԉ();Ԕ();Ե();ړ=ы.Н.RegisterBroadcastListener(Ґ.Ҝ);ڒ=ы.Н.
RegisterBroadcastListener(Ґ.ҥ);ڔ=ы.Н.RegisterBroadcastListener(Ґ.Ҩ);ԣ=ы.Н.RegisterBroadcastListener(Ґ.Ҥ);ڑ=ы.Н.RegisterBroadcastListener(Ґ.Ҧ);ڐ=ы
.Н.RegisterBroadcastListener(Ґ.ҧ);г(ї.е,(Ŗ)=>{Ŗ.Ã();int ڄ=0,ڃ=0,ڂ=0;foreach(var ª in ĭ){var ځ=ª.Key.Item1;if(ځ==Ӄ.ҿ)ڄ++;
else if(ځ==Ӄ.Ӏ)ڃ++;else ڂ++;}Ŗ.È("E:"+ڄ+"|A:"+ڃ+"|O:"+ڂ);Ŗ.È(ڗ.ToString());Ŗ.È(Φ.CustomName);});}í();ê();ˤ();}public
override void ʝ(UpdateFrequency è){var س=ы.Ϲ;if(ԗ)Ԉ();ԥ();if(ˊ%30==0){if(ƅ==null){if(!ԗ)Թ();ԉ();}Ԕ();}if(ˊ%10==0){Ե();}if(ˊ%100
==0&&ƅ==null){Ը();if(ԗ){Ԅ();Ԃ();}else{Զ();}}ˊ++;}public int ڌ(long ڀ){if(ԗ){int r;if(!ԝ.TryGetValue(ڀ,out r))r=2;return r;
}else{if(ԛ.ContainsKey(ڀ))return ԛ[ڀ];if(Ԟ==null||!Ԟ.ContainsKey(ڀ))return 2;return Ԟ[ڀ];}}public void ڝ(long ڀ,int ē){if
(ԗ){ԝ[ڀ]=ē;}else{ԛ[ڀ]=ē;Ԛ.Add(ڀ);ы.Н.SendBroadcastMessage(Ґ.ҥ,MyTuple.Create(ڀ,ē));}}public Dictionary<MyTuple<Ӄ,long>,Ҿ>
ڛ(){if(ƅ!=null)return ƅ.ڛ();if(ы.Ϲ==ә.Ә)return ĭ;Թ();return ĭ;}public double ښ(MyTuple<Ӄ,long>N){if(ƅ!=null)return ƅ.ښ(N)
;if(!ڏ.ContainsKey(N))return double.MaxValue;return ڏ[N];}public void ڙ(Ҿ ѯ){if(ѯ.Ћ==null)throw new Exception(
"Null Intel Name");if(Ԥ!=0&&!ԗ){Ԝ.ForEach(Ԇ=>Ԇ.Җ(ы,ѯ,Ԥ));}MyTuple<Ӄ,long>ı=Ґ.Ѱ(ѯ);ڏ[ı]=ы.Ϲ;if(!ĭ.ContainsKey(ı)||ĭ[ı]!=ѯ)ĭ[ı]=ѯ;}public
double ژ{get{if(ƅ!=null)return ƅ.ژ;return ڗ;}set{ڗ=value;}}double ڗ;public bool ږ{get{return Ԥ!=0;}}public IMyShipController Φ
=>Ԡ;public void ڜ(Д Ţ,Ń š,MyTuple<Ӄ,long>ţ,Ѯ Ҏ=Ѯ.ѭ){if(ƅ!=null)ƅ.ڜ(Ţ,š,ţ,Ҏ);if(Ţ.ќ==ы.ʬ.CubeGrid.EntityId&&Ԙ!=null){Ԙ.ѝ(š,
ţ,Ѯ.ѭ,0);}else{ы.Н.SendBroadcastMessage(Ţ.Б,MyTuple.Create((int)š,MyTuple.Create((int)ţ.Item1,ţ.Item2),(int)Ҏ,0));}}
public void ڕ(р Ի){ԟ.Add(Ի);}IMyBroadcastListener ڔ,ړ,ڒ,ڑ,ڐ;Dictionary<MyTuple<Ӄ,long>,Ҿ>ĭ=new Dictionary<MyTuple<Ӄ,long>,Ҿ>()
;Dictionary<MyTuple<Ӄ,long>,double>ڏ=new Dictionary<MyTuple<Ӄ,long>,double>();List<MyTuple<Ӄ,long>>ڎ=new List<MyTuple<Ӄ,
long>>();public Dictionary<long,Ϻ>ڍ=new Dictionary<long,Ϻ>();double װ=2000;long Ԥ;int Ֆ;IMyBroadcastListener ԣ;long Ԣ;int ԡ;
IMyShipController Ԡ;HashSet<р>ԟ=new HashSet<р>();ImmutableDictionary<long,int>Ԟ=null;Dictionary<long,int>ԝ=new Dictionary<long,int>();
List<Ҙ>Ԝ=new List<Ҙ>();Dictionary<long,int>ԛ=new Dictionary<long,int>();HashSet<long>Ԛ=new HashSet<long>();List<long>ԙ=new
List<long>();int ˊ=0;public Ѡ Ԙ;bool ԗ=false;int Ў=0;څ ƅ;public څ(int Ԗ=0,څ ԕ=null){Ў=Ԗ;ƅ=ԕ;}void ê(){ڰ é=new ڰ();if(!é.ڬ(ы.
ʬ))return;Ў=é.ڋ("Intel","Rank",Ў);}void ˤ(){ъ["wipe"]=(î)=>{ĭ.Clear();ڏ.Clear();};}void í(){Ԡ=null;ы.ϊ.GetBlocksOfType<
IMyTerminalBlock>(null,ς);}bool ς(IMyTerminalBlock đ){if(!ŕ.Œ(ы.ʬ,đ))return false;ŕ.ŉ(ref Ԡ,đ,"[I]");return false;}void Ԕ(){if(ы.Ϲ==ә.Ә)
return;if(Ԡ==null)return;Д ҋ;IMyCubeGrid ԓ=ы.ʬ.CubeGrid;var N=MyTuple.Create(Ӄ.Ӏ,ԓ.EntityId);if(ĭ.ContainsKey(N))ҋ=(Д)ĭ[N];
else ҋ=new Д();ҋ.Ћ=ԓ.DisplayName;ҋ.ϰ=Ԡ.GetShipVelocities().LinearVelocity;ҋ.Г=ԓ.WorldAABB.Center;ҋ.һ=(float)ŕ.Ą(ԓ);ҋ.ϯ=ы.И;ҋ
.ќ=ԓ.EntityId;ҋ.ł=ł.Ĺ;foreach(var Ի in ԟ)Ի.ч(ҋ);if(ƅ!=null)ƅ.ڙ(ҋ);else ڙ(ҋ);}void Թ(){while(ڔ.HasPendingMessage){var Ѷ=ڔ.
AcceptMessage();if(Ѷ.Source==Ԥ)Ԝ.ForEach(Ԇ=>Ԇ.Ғ(ы,Ѷ.Data,ĭ,ref ڎ,Ԥ));}foreach(var N in ڎ){ڏ[N]=ы.Ϲ;}ڎ.Clear();}void Ը(){foreach(var t
in ڏ){if(t.Key.Item1==Ӄ.Ӂ)continue;var Է=t.Value+װ;if(t.Key.Item1==Ӄ.І)Է+=1000;if(Է<ы.Ϲ){ڎ.Add(t.Key);}}foreach(var N in ڎ
){ĭ.Remove(N);ڏ.Remove(N);}ڎ.Clear();}void Զ(){ԙ.Clear();foreach(var t in ԛ)if(!Ԛ.Contains(t.Key))ԙ.Add(t.Key);foreach(
var ǘ in ԙ)ԛ.Remove(ǘ);Ԛ.Clear();while(ڑ.HasPendingMessage){var Ѷ=ڑ.AcceptMessage();if(Ѷ.Source==Ԥ){Ԟ=(ImmutableDictionary<
long,int>)Ѷ.Data;}}}void Ե(){if(ڐ==null)return;var Ժ=(int)ї.ѓ;while(ڐ.HasPendingMessage){var Ѷ=ڐ.AcceptMessage();var Դ=Ѷ.
Source;var Ϥ=(MyTuple<double,ImmutableDictionary<long,double>,ImmutableDictionary<string,ImmutableArray<string>>>)(Ѷ.Data);Ϻ Գ
;if(!ڍ.TryGetValue(Դ,out Գ))ڍ[Դ]=Գ=new Ϻ();if(Գ.Ϲ<ы.Ϲ){Գ.Ϲ=ы.Ϲ;foreach(var t in Ϥ.Item2){Գ.ϸ[t.Key]=t.Value;}foreach(var
t in Ϥ.Item3){string[]Բ;if(!Գ.Ϸ.TryGetValue(t.Key,out Բ))Գ.Ϸ[t.Key]=Բ=new string[Ժ];for(int Ŵ=0;Ŵ<Ժ;++Ŵ)Բ[Ŵ]=t.Value[Ŵ];}
}}var Ա=new Dictionary<string,ImmutableArray<string>>();var ԧ=new MyTuple<double,ImmutableDictionary<long,double>,
ImmutableDictionary<string,ImmutableArray<string>>>();ԧ.Item1=ы.Ϲ;ԧ.Item2=ы.ϸ.ToImmutableDictionary();foreach(var t in ы.Ж){var Я=t.Value;
if(Я.ш){var Ԧ=new string[Ժ];for(int Ŵ=0;Ŵ<Ժ;++Ŵ)Ԧ[Ŵ]=ђ.ю(Я.щ[Ŵ]);Я.ш=false;}}ԧ.Item3=Ա.ToImmutableDictionary();}void ԥ(){
if(ы.Ϲ==0)return;MyIGCMessage?Ѷ=null;while(ԣ.HasPendingMessage)Ѷ=ԣ.AcceptMessage();if(Ѷ!=null){var Ԋ=(MyIGCMessage)Ѷ;if(Ԋ.
Data is MyTuple<double,int,long>){var ϣ=(MyTuple<double,int,long>)Ԋ.Data;if(ϣ.Item2>Ֆ||(ϣ.Item2==Ֆ&&ϣ.Item3>Ԥ)){Ֆ=ϣ.Item2;Ԥ=
ϣ.Item3;}if(Ԥ==ϣ.Item3){ڗ=ϣ.Item1+ә.ӗ-ы.Ϲ;}if(ϣ.Item2>ԡ||(ϣ.Item2==ԡ&&ϣ.Item3>Ԣ)){ԡ=ϣ.Item2;Ԣ=ϣ.Item3;if(ԗ)Ԁ(Ԣ,ԡ);}}}}
void ԉ(){if(ы.Ϲ==0)return;if(ԗ)Ԝ.ForEach(Ԇ=>Ԇ.ҕ(ы,ĭ,ы.Н.Me));if(Ў>0){ы.Н.SendBroadcastMessage(Ґ.Ҥ,MyTuple.Create(ы.Ϲ,Ў,ы.Н.
Me));}if(Ԣ==ы.Н.Me&&!ԗ&&Ў>0){ԁ();}if(Ԣ!=Ԥ){Ֆ=0;Ԥ=0;}ԡ=Ў;Ԣ=ы.Н.Me;}void Ԉ(){var ԇ=new List<IMyBroadcastListener>();ы.Н.
GetBroadcastListeners(ԇ);while(ړ.HasPendingMessage){var Ѷ=ړ.AcceptMessage();foreach(var Ԇ in Ԝ){var ԅ=Ԇ.Ҕ(ы,Ѷ.Data,ĭ,ы.Н.Me);if(ԅ.HasValue){ڏ
[ԅ.Value]=ы.Ϲ;break;}}if(Ѷ.Data is MyTuple<long,MyTuple<int,long,MyTuple<MyTuple<Vector3D,Vector3D,double>,MyTuple<string
,long,float,int>,MyTuple<int,string,int,int,Vector3I>,MyTuple<long,int>>>>){var ϣ=(MyTuple<long,MyTuple<int,long,MyTuple<
MyTuple<Vector3D,Vector3D,double>,MyTuple<string,long,float,int>,MyTuple<int,string,int,int,Vector3I>,MyTuple<long,int>>>>)(Ѷ.
Data);}}}void Ԅ(){while(ڒ.HasPendingMessage){var Ѷ=ڒ.AcceptMessage();if(!(Ѷ.Data is MyTuple<long,int>))continue;MyTuple<long
,int>ϣ=(MyTuple<long,int>)Ѷ.Data;var ԃ=Math.Max(0,Math.Min(4,ϣ.Item2));ԝ[ϣ.Item1]=ԃ;}}void Ԃ(){ы.Н.SendBroadcastMessage(Ґ
.Ҧ,ԝ.ToImmutableDictionary());}void ԁ(){ԗ=true;Ԥ=ы.ʬ.EntityId;Ֆ=Ў;if(Ԟ!=null)foreach(var t in Ԟ)ԝ.Add(t.Key,t.Value);ڗ=ә.
Ә;}void Ԁ(long ӿ,int Ӿ){ԗ=false;Ԥ=ӿ;Ԟ=null;Ֆ=Ӿ;ԝ.Clear();}}public class ӽ{const int Ӽ=40;string[]ӻ;int Ӻ=0;public ӽ(){ӻ=
new string[Ӽ];}public void е(string Ѷ){ӻ[Ӻ]="> "+Ѷ;Ӻ=(Ӻ+1)%Ӽ;}public void э(Ë ˀ){for(int Ŵ=0;Ŵ<ӻ.Length;++Ŵ){if(Ŵ==Ӻ)ˀ.È(
"==== WRAP ====");else ˀ.È(ӻ[Ŵ]);}}}public class ԋ:ь{void ˤ(){ъ["activateplugin"]=(î)=>{var ˣ=î.ӛ(1);ԍ(ˣ);};ъ["cycleplugin"]=(î)=>{Լ();}
;ъ["up"]=ъ["8"]=(î)=>{ב(8);};ъ["down"]=ъ["5"]=(î)=>{ב(5);};ъ["left"]=ъ["4"]=(î)=>{ב(4);};ъ["right"]=ъ["6"]=(î)=>{ב(6);};ъ
["enter"]=ъ["3"]=(î)=>{ב(3);};ъ["cancel"]=ъ["7"]=(î)=>{ב(7);};}public override void Ƃ(){Р|=UpdateFrequency.Update10;í();ˤ
();г(ї.е,(Ŗ)=>{Ŗ.È("Active Ok="+ԏ.צ());});}public override void ʝ(UpdateFrequency è){if((è&UpdateFrequency.Update10)!=0){
տ();}}public ԋ(string ò="LG"){Τ=ò;ý="["+ò;}Dictionary<string,Ɔ>Ԓ=new Dictionary<string,Ɔ>();List<Ɔ>ԑ=new List<Ɔ>();Ɔ Ԑ=
null;public ռ ԏ=null;public IMyShipController Φ;string Τ;string ý;void í(){ԏ?.Ã();Φ=null;ԏ=new ռ();ԏ.ק=this;ŕ.ō(ы,ς);ԏ.Ю();}
void ς(IMyTerminalBlock đ){if(!ŕ.Œ(ы.ʬ,đ))return;ŕ.ŉ(ref Φ,đ,ý,(Ŗ)=>Ŗ.CanControlShip);if(ŕ.Ņ(đ,ý))ԏ.Ω(đ);}public void Ԏ(
string Ɗ,Ɔ Ԍ){if(Ԓ.ContainsKey(Ɗ))return;Ԓ[Ɗ]=Ԍ;Ԍ.ƅ=this;ԑ.Add(Ԍ);Ԍ.Ƃ();if(Ԑ==null)Ԑ=Ԍ;}public void ԍ(string Ɗ){Ɔ Ԍ;if(Ԓ.
TryGetValue(Ɗ,out Ԍ))Ԑ=Ԓ[Ɗ];}void Լ(){var ʟ=ԑ.IndexOf(Ԑ);ʟ++;if(ʟ>=ԑ.Count)ʟ=0;Ԑ=ԑ[ʟ];}void ב(int Ŵ){ы.е.љ.е("CallAction("+Ŵ+")");
if(Ԑ.Ƅ.ContainsKey(Ŵ))Ԑ.Ƅ[Ŵ].Invoke();}public void א(int և,string Å,Ë ˀ){int ү=Å.Length;if(ү>և)ˀ.È(Å.Substring(0,և));else
if(ү<և)ˀ.Æ(Å).Æ(' ',և-ү).È();else ˀ.È(Å);}public int ֆ(int օ,int ք){return(օ%ք+ք)%ք;}public int փ(int Ö,int ˮ,bool ւ){if(ˮ
==0)return 0;int ց=Ö+(ւ?1:-1);if(ց>=ˮ)ց=0;if(ց<=-1)ց=ˮ-1;return ց;}public void ր(Ҿ ª){ы.Ъ.ڙ(ª);}void տ(){foreach(var t in
Ԓ){if(ԏ!=null&&t.Value==Ԑ)t.Value.ƃ();}}public void վ(List<MySprite>թ){var ս=new MySprite(SpriteType.TEXTURE,"Cross",size
:new Vector2(10f,10f),color:new Color(1,1,1,0.4f));ս.Position=new Vector2(0,-2)+512/2f;թ.Add(ս);}}public class ռ{enum ջ{պ
,չ,ո,}List<List<IMyTextPanel>>ג=new List<List<IMyTextPanel>>(3);public IMyShipController Φ{get{return ק.Φ;}}public List<
IMyTextPanel>ד=new List<IMyTextPanel>();public List<IMyTextPanel>ת=new List<IMyTextPanel>();public List<IMyTextPanel>ש=new List<
IMyTextPanel>();public IMyCameraBlock ר;public ԋ ק;public bool צ(){if(ד.Count==0)return false;if(ש.Count==0)return false;if(ת.Count
==0)return false;if(ר==null)return false;return true;}public void Ю(){foreach(var ץ in ד){ץ.Alignment=TextAlignment.RIGHT;
ץ.FontSize=0.55f;ץ.TextPadding=9;ץ.Font=ә.ӕ;ץ.ContentType=ContentType.TEXT_AND_IMAGE;}foreach(var פ in ת){פ.FontSize=
0.55f;פ.TextPadding=9;פ.Font=ә.ӕ;פ.ContentType=ContentType.TEXT_AND_IMAGE;}foreach(var ף in ש){ף.ScriptBackgroundColor=new
Color(1,0,0,0);ף.ContentType=ContentType.SCRIPT;}}public void Ã(){ר=null;ד.Clear();ת.Clear();ש.Clear();}public void Ω(
IMyTerminalBlock đ){ŕ.ŉ(ש,đ,"[SN-SM]");ŕ.ŉ(ד,đ,"[SN-SL]");ŕ.ŉ(ת,đ,"[SN-SR]");ŕ.ŉ(ref ר,đ,"[SN-C-P]");}public MyDetectedEntityInfo ע;
public bool ס(){MatrixD ĝ;if(ר!=null)ĝ=ר.WorldMatrix;else if(ק.Φ!=null)ĝ=ק.Φ.WorldMatrix;else return false;Vector3D X=ĝ.
Translation+(ĝ.Forward*1e6);ӣ Ǜ=new ӣ();Ǜ.ӝ("scanner designate "+X.X+" "+X.Y+" "+X.Z);ק.ы.Х(Ǜ);return true;}public const float ן=
1.06f;public const float מ=1.6f;public const int ם=512;public Vector2 ל=new Vector2(18.68108f,28.8f);public Vector2 כ=new
Vector2(18.68108f,28.8f);const float ך=0.25f;const float י=0.5f;const float ט=1000;const float ח=10000;[Flags]public enum ז{Ĺ=0
,ו=1<<0,ה=1<<1,נ=1<<2,շ=1<<3,ժ=1<<4,Օ=1<<5,Ք=1<<6,Փ=1<<7,Ւ=1<<8,Ց=1<<9,Ր=1<<10,}static string Տ=
"MyObjectBuilder_TextPanel/";Dictionary<MyDefinitionId,Vector3>Վ=new Dictionary<MyDefinitionId,Vector3>(){{ŕ.ŏ(Տ+"LargeLCDPanel3x3"),new Vector3(
7.3958f,7.3958f,.234375f)},{ŕ.ŏ(Տ+"LargeLCDPanel5x3"),new Vector3(12.49f,7.3958f,.234375f)},{ŕ.ŏ(Տ+"LargeLCDPanel5x5"),new
Vector3(12.49f,12.49f,.234375f)},{ŕ.ŏ(Տ+"TransparentLCDLarge"),new Vector3(2.0833f,2.0833f,1.198f)},{ŕ.ŏ(Տ+
"TransparentLCDSmall"),new Vector3(0.49f,0.49f,.234375f)},};public Vector3D Ս(IMyTextPanel Յ,out Vector2 Ռ){var Ջ=Յ.CubeGrid.GridSizeEnum==
MyCubeSize.Large;Vector3 Պ;if(!Վ.TryGetValue(Յ.BlockDefinition,out Պ))Պ=new Vector3(Ջ?2.3958f:0.42188f,Ջ?2.3958f:0.42188f,Ջ?1.026f
:0.16797f);Ռ.X=Պ.X;Ռ.Y=Պ.Y;return Յ.GetPosition()+Յ.WorldMatrix.Forward*1.198;}Vector3D Չ(IMyCameraBlock Ո,Vector3D Շ){
return ר.GetPosition()+Շ*(Ո.CubeGrid.GridSizeEnum==MyCubeSize.Large?.25f:.20f);}bool Ն(IMyTextPanel Յ,Ҿ ª,out float Մ,out
Vector2 Ճ,out Vector2 Ղ){var Ձ=ª.ҽ(ק.ы.И)-ר.WorldMatrix.Translation;var Հ=Յ.WorldMatrix.Translation-ר.WorldMatrix.Translation;Հ
.Normalize();var Կ=Vector3D.TransformNormal(Ձ,MatrixD.Transpose(MatrixD.CreateWorld(ר.Position,Հ,Յ.WorldMatrix.Up)));var
Ծ=new Vector2(-1*(float)(Կ.X/Կ.Z),(float)(Կ.Y/Կ.Z));if(Կ.Dot(Vector3D.Forward)>0){Մ=(float)Կ.Length();Ճ=Ծ*(ר.CubeGrid.
GridSizeEnum==MyCubeSize.Small?ן:מ);Ղ=(Ճ+.5f)*ם;Ղ.X=Math.Max(30,Math.Min(ם-30,Ղ.X));Ղ.Y=Math.Max(30,Math.Min(ם-30,Ղ.Y));return true;
}Ղ=Vector2.PositiveInfinity;Ճ=Ղ;Մ=Ղ.X;return false;}bool Խ(IMyTextPanel Յ,Ҿ ª,out float Մ,out Vector2 Ճ,out Vector2 Ղ){Ճ=
Vector2.PositiveInfinity;Ղ=Ճ;Vector3D ն,յ,մ,ճ,ղ,ձ;Vector2 հ;յ=Ս(Յ,out հ);ն=Չ(ר,ר.WorldMatrix.Forward);MatrixD կ=MatrixD.
CreateWorld(յ,Յ.WorldMatrix.Forward,Յ.WorldMatrix.Up);var ծ=MatrixD.Invert(կ);ճ=Vector3D.Transform(ն,ծ);մ=Vector3D.Transform(ª.ҽ(ק.
ы.Ϲ),ծ);ղ=մ-ճ;Մ=(float)ղ.Length();var խ=new PlaneD(Vector3D.Zero,Vector3.Forward);if(!ǭ.Ƥ(խ,ճ,Vector3D.Normalize(ղ),out ձ
))return false;var լ=(հ*.9f)/2f;Ճ=new Vector2(MathHelper.Clamp((float)ձ.X,-լ.X,լ.X),-1*MathHelper.Clamp((float)ձ.Y,-լ.Y,լ
.Y));Ճ/=հ;Ղ=Ճ+0.5f;Ղ*=ם;return true;}public Vector2 ի(IMyTextPanel Յ,Ҿ ª,Color Ҵ,ref List<MySprite>թ,ז ը=ז.Ĺ){var Ԧ=
Vector2.PositiveInfinity;if(ª.ќ==ק.ы.ʬ.CubeGrid.EntityId)return Ԧ;float ʻ;Vector2 է;if(!Ն(Յ,ª,out ʻ,out Ԧ,out է))return Ԧ;var ɒ
=է;float զ=י;if(ʻ>ח)զ=ך;else if(ʻ>ט)զ=ך+(י-ך)*(ח-ʻ)/(ח-ט);if((ը&ז.Օ)!=0)զ*=1.5f;else if((ը&ז.Ք)!=0)զ*=0.5f;string ե;bool
դ=(ը&ז.Փ)!=0;bool գ=(ը&ז.ו)!=0;bool բ=(ը&ז.ה)!=0;bool ա=(ը&ז.Ց)!=0;if(ա){if(գ&&բ)ե="-[ ]-";else if(գ)ե="[ ]";else if(բ)ե=
"- -";else ե=" ";}else if(դ){if(գ&&բ)ե="-[O]-";else if(գ)ե="[O]";else if(բ)ե="-O-";else ե="O";}else{if(գ&&բ)ե="-[><]-";else
if(գ)ե="[><]";else if(բ)ե="-><-";else ե="><";}bool ՙ=(ը&ז.Ւ)!=0;if(ՙ){var ϗ=new MySprite(SpriteType.TEXTURE,"Cross",size:
new Vector2(30f,30f));ϗ.Position=ɒ;թ.Add(ϗ);}ɒ.Y-=զ*(ל.Y+10)/2;var Ƌ=MySprite.CreateText(ե,ә.ӕ,Ҵ,զ,TextAlignment.CENTER);Ƌ.
Position=ɒ;թ.Add(Ƌ);ɒ.Y+=ל.Y*զ+0.2f;var ˀ=ק.ы.М;ˀ.Ã();if((ը&ז.נ)!=0)ˀ.È((int)ʻ+" m");if((ը&ז.շ)!=0||(ը&ז.ժ)!=0){var Ɗ=ª.Ћ;if(Ɗ.
StartsWith("L-")||Ɗ.StartsWith("S-"))Ɗ=Ɗ.Substring(0,Math.Min(Ɗ.Length,8));ˀ.È(Ɗ);}if((ը&ז.Ր)!=0&&(ª is х)){var Ɖ=(х)ª;var ƈ=ק.ы.Ϲ
-Ɖ.ϯ;ˀ.È((int)ƈ+" ms");}if(ˀ.Â>0){var Ƈ=MySprite.CreateText(ˀ.ToString(),ә.Ӕ,new Color(1,1,1,0.5f),(ը&ז.Ք)!=0?0.3f:0.4f,
TextAlignment.CENTER);Ƈ.Position=ɒ;թ.Add(Ƈ);}return Ԧ;}}public abstract class Ɔ{public ԋ ƅ{get;set;}public Dictionary<int,Action>Ƅ=
new Dictionary<int,Action>();public abstract void ƃ();public abstract void Ƃ();}class Ɓ:Ɔ{public override void Ƃ(){Ƅ[3]=()
=>{var ƀ=ƅ.ы.Ϲ;if(ź==ž.Ž){if(Ɵ<ƞ.Count&&ƌ!=А.Ĺ)ź=ž.ż;}else if(ź==ž.ż){if(Ɠ<Ɨ[Ɩ[ƕ]].Length){string ſ=Ɨ[Ɩ[ƕ]][Ɠ];if(ſ==
"CURSOR"){ź=ž.Ż;}if(ſ=="HOME"){Ť(MyTuple.Create(Ӄ.ӂ,(long)0));ź=ž.Ž;}if(ſ=="DESIGNATE"){ź=ž.Y;}if(ſ=="CLEAR"){Ť(MyTuple.Create(Ӄ
.ӂ,(long)0));ź=ž.Ž;}}else if(Ɠ<Ɨ[Ɩ[ƕ]].Length+Ɣ.Count){Ť(Ɣ[Ɠ-Ɨ[Ɩ[ƕ]].Length]);ź=ž.Ž;}}else if(ź==ž.Ż){І Ş=ş();Ş.Ђ=100;ƅ.ր
(Ş);Ť(Ş);}else if(ź==ž.Y){ƅ.ԏ.ס();if(!ƅ.ԏ.ע.IsEmpty()&&ƅ.ԏ.ע.Type==MyDetectedEntityType.Asteroid){var Ş=new І();Ş.Ѕ=(
Vector3D)ƅ.ԏ.ע.HitPosition;Ş.V=ƅ.ԏ.ר.WorldMatrix.Backward;ƅ.ր(Ş);Ť(Ş);}ź=ž.Ž;}};Ƅ[4]=()=>{if(ź==ž.Ž){ƌ=Ɯ(ƌ,-1);Ɵ=0;}else if(ź==ž
.ż){ƕ=ƅ.փ(ƕ,Ɩ.Count,false);}};Ƅ[5]=()=>{if(ź==ž.Ž){Ɵ=ƅ.փ(Ɵ,ƞ.Count,true);}else if(ź==ž.ż){Ɠ=ƅ.փ(Ɠ,Ɣ.Count+Ɨ[Ɩ[ƕ]].Length,
true);}else if(ź==ž.Ż){Š-=200;if(Š<200)Š=200;}};Ƅ[6]=()=>{if(ź==ž.Ž){ƌ=Ɯ(ƌ,1);Ɵ=0;}else if(ź==ž.ż){ƕ=ƅ.փ(ƕ,Ɩ.Count,true);}};
Ƅ[7]=()=>{if(ź==ž.ż){ź=ž.Ž;}else if(ź==ž.Ż||ź==ž.Y){ź=ž.ż;}};Ƅ[8]=()=>{if(ź==ž.Ž){Ɵ=ƅ.փ(Ɵ,ƞ.Count,false);}else if(ź==ž.ż)
{Ɠ=ƅ.փ(Ɠ,Ɣ.Count+Ɨ[Ɩ[ƕ]].Length,false);}else if(ź==ž.Ż){Š+=200;}};}public override void ƃ(){ų();Ź();ƒ();}enum ž{Ž,ż,Ż,Y,}
ž ź=ž.Ž;List<MySprite>ř=new List<MySprite>();void Ź(){var ū=ƅ.ы.М;ū.Ã();int ŷ=19;int Ÿ=16;ū.È("===== COMMAND =====");ū.È(
);ū.Æ(Ɲ[Ɯ(ƌ,-1)]).Æ("    [").Æ(Ɲ[ƌ]).Æ("]    ").È(Ɲ[Ɯ(ƌ,+1)]);if(ź==ž.Ž)ū.È("[<4]           [6>]");else ū.È();ū.È();ƞ.
Clear();foreach(Ҿ ª in ƅ.ы.Ъ.ڛ().Values){if(ª is Д&&((Д)ª).А==ƌ)ƞ.Add((Д)ª);}ƞ.Sort(Ґ.ҏ);for(int Ŵ=0;Ŵ<Ÿ;Ŵ++){if(Ŵ<ƞ.Count){
var ª=ƞ[Ŵ];if(Ŵ==Ɵ)ū.Æ(">> ");else ū.Æ("   ");ƅ.א(ŷ-3,ª.Ћ,ū);}else{ū.È();}}ū.È("==== SELECTION ====");if(Ɵ<ƞ.Count){ƅ.א(ŷ,ƞ
[Ɵ].Ћ,ū);if(ź==ž.Ž)ƅ.א(ŷ,"[NUM 0] SELECT TGT",ū);}else{ƅ.א(ŷ,"NONE SELECTED",ū);}foreach(var Ų in ƅ.ԏ.ד){Ų.FontColor=ź==ž
.Ž?ә.ӹ:ә.Ӹ;Ų.WriteText(ū.ToString());}}А ƌ=А.ѩ;int Ɵ=0;List<Д>ƞ=new List<Д>();Dictionary<А,string>Ɲ=new Dictionary<А,
string>{{А.Ĺ,"N/A"},{А.Ѫ,"DRN"},{А.ѩ,"FTR"},{А.Ѩ,"BMR"},{А.ѧ,"MNR"},};А Ɯ(А ƛ,int ƚ=1){return(А)ƅ.ֆ((int)ƛ+ƚ,(int)А.Ѧ);}
Dictionary<Ń,string>ƙ=new Dictionary<Ń,string>{{Ń.Ĺ,"N/A"},{Ń.Ł,"MOV"},{Ń.ŀ,"SMV"},{Ń.Ľ,"ATK"},{Ń.Ļ,"DEF"},{Ń.Ŀ,"DOK"},{Ń.ľ,"HOM"}
,{Ń.ļ,"MNE"}};Dictionary<Ń,Ӄ>Ƙ=new Dictionary<Ń,Ӄ>{{Ń.Ĺ,Ӄ.ӂ},{Ń.Ł,Ӄ.І},{Ń.ŀ,Ӄ.І},{Ń.Ľ,Ӄ.ҿ|Ӄ.І},{Ń.Ļ,Ӄ.І},{Ń.Ŀ,Ӄ.ӂ},{Ń.ľ,Ӄ
.ӂ},{Ń.ļ,Ӄ.І}};Dictionary<Ń,string[]>Ɨ=new Dictionary<Ń,string[]>{{Ń.Ĺ,new string[0]},{Ń.Ł,new string[1]{"CURSOR"}},{Ń.ŀ,
new string[1]{"CURSOR"}},{Ń.Ľ,new string[1]{"CURSOR"}},{Ń.Ļ,new string[1]{"CURSOR"}},{Ń.Ŀ,new string[1]{"HOME"}},{Ń.ľ,new
string[1]{"CLEAR"}},{Ń.ļ,new string[1]{"DESIGNATE"}}};List<Ń>Ɩ=new List<Ń>();int ƕ=0;List<Ҿ>Ɣ=new List<Ҿ>();int Ɠ;void ƒ(){var
ū=ƅ.ы.М;ū.Ã();foreach(var Ų in ƅ.ԏ.ת){Ų.FontColor=ź==ž.ż?ә.ӹ:ә.Ӹ;}ū.È("=== SELECT TASK ===");ū.È();if(Ɵ>=ƞ.Count){foreach
(var Ų in ƅ.ԏ.ת){Ų.WriteText(ū.ToString());}ź=ž.Ž;return;}var Ɛ=ƞ[Ɵ];Ɩ.Clear();for(int Ŵ=0;Ŵ<30;Ŵ++){if(((Ń)(1<<Ŵ)&Ɛ.В)!=
0)Ɩ.Add((Ń)(1<<Ŵ));}if(Ɩ.Count==0){foreach(var Ų in ƅ.ԏ.ת){Ų.WriteText(ū.ToString());}return;}if(ƕ>=Ɩ.Count)ƕ=0;ū.Æ(ƙ[Ɩ[ƅ
.ֆ(ƕ-1,Ɩ.Count)]]).Æ("    [").Æ(ƙ[Ɩ[ƕ]]).Æ("]    ").È(ƙ[Ɩ[ƅ.ֆ(ƕ+1,Ɩ.Count)]]);if(ź==ž.ż)ū.È("[<4]           [6>]");else ū
.È();ū.È();Ɣ.Clear();foreach(Ҿ ª in ƅ.ы.Ъ.ڛ().Values){if((ª.Ы&Ƙ[Ɩ[ƕ]])!=0)Ɣ.Add(ª);else if((Ɩ[ƕ]==Ń.Ŀ||Ɩ[ƕ]==Ń.ľ)&&ª.Ы==Ӄ
.Ŀ&&ϵ.ц(Ɛ.Ϝ,((ϵ)ª).ϭ))Ɣ.Add(ª);}Ɣ.Sort(Ґ.ҏ);int Ÿ=16;int ŷ=19;int Ə=Ɨ[Ɩ[ƕ]].Length;for(int Ŵ=0;Ŵ<Ÿ;Ŵ++){if(Ŵ<Ə){if(Ŵ==Ɠ)ū
.Æ(">> ");else ū.Æ("   ");ƅ.א(ŷ-3,Ɨ[Ɩ[ƕ]][Ŵ],ū);}else if(Ə<Ŵ&&Ŵ<Ɣ.Count+Ə+1){if(Ŵ==Ɠ+1)ū.Æ(">> ");else ū.Æ("   ");var ª=Ɣ
[Ŵ-Ə-1];if(ª is ϵ){var Ǝ=(ϵ)ª;ū.Æ(Ǝ.Ϯ!=-1?((Ǝ.Ī&Ϣ.Ϡ)!=0?"[R]":"[C]"):"[ ]");ƅ.א(ŷ-6,ª.Ћ,ū);}else{ƅ.א(ŷ-3,ª.Ћ,ū);}}else{ū.
È();}}ū.È();ū.È("==== SELECTION ====");if(Ɠ<Ə){ƅ.א(ŷ,Ɨ[Ɩ[ƕ]][Ɠ],ū);if(ź==ž.ż){ƅ.א(ŷ,"[NUM 3] SELECT",ū);ƅ.א(ŷ,
"[7] CANCEL CMD",ū);}}else if(Ə<=Ɠ&&Ɠ<Ɣ.Count+Ə){ƅ.א(ŷ,Ɣ[Ɠ-Ə].ќ.ToString(),ū);if(ź==ž.ż){ƅ.א(ŷ,"[NUM 3] SEND CMD",ū);ƅ.א(ŷ,
"[7] CANCEL CMD",ū);}}else{ƅ.א(ŷ,"NONE SELECTED",ū);}foreach(var Ų in ƅ.ԏ.ת){Ų.WriteText(ū.ToString());}}void ų(){int ƍ=-1;if(Ɩ.Count>0)
{if(ƕ>=Ɩ.Count)ƕ=0;ƍ=Ɠ-Ɨ[Ɩ[ƕ]].Length;}ř.Clear();if(ƅ.ԏ.ש.Count==0)return;foreach(var Ų in ƅ.ԏ.ש){ƅ.վ(ř);foreach(Ҿ ª in ƅ
.ы.Ъ.ڛ().Values){if(ª.Ы==Ӄ.Ӏ){var Ř=ռ.ז.Ք;if(ƞ.Count>Ɵ&&ª==ƞ[Ɵ])Ř=ռ.ז.շ|ռ.ז.נ|ռ.ז.ה;ƅ.ԏ.ի(Ų,ª,ә.ӓ,ref ř,Ř);}else if(ª.Ы==
Ӄ.ҿ){var Ř=ռ.ז.נ;if(ƍ>=0&&Ɣ.Count>ƍ&&ª==Ɣ[ƍ])Ř|=ռ.ז.ה;int r=ƅ.ы.Ъ.ڌ(ª.ќ);if(r==0)Ř|=ռ.ז.Փ|ռ.ז.Ք;else if(r==1)Ř|=ռ.ז.Ք;
else if(r==3)Ř|=ռ.ז.Օ;else if(r==4)Ř|=ռ.ז.Օ|ռ.ז.ו;ƅ.ԏ.ի(Ų,ª,ә.Ӧ,ref ř,Ř);}else if(ª.Ы==Ӄ.І){var Ř=ռ.ז.נ;ƅ.ԏ.ի(Ų,ª,ә.ӑ,ref ř,
Ř);}}using(var ũ=Ų.DrawFrame()){if(ź==ž.Ż){var Ũ=MySprite.CreateText(Š.ToString()+" m",ә.Ӕ,ә.ӧ,0.5f);Ũ.Position=new
Vector2(0,5)+Ų.TextureSize/2f;ũ.Add(Ũ);var Ŧ=MySprite.CreateText("[5|W/8|S] +/- DIST",ә.Ӕ,ә.ӧ,0.4f);Ŧ.Position=new Vector2(0,20
)+Ų.TextureSize/2f;ũ.Add(Ŧ);var ŧ=MySprite.CreateText("[3|SPACE] CONFIRM",ә.Ӕ,ә.ӧ,0.4f);ŧ.Position=new Vector2(0,34)+Ų.
TextureSize/2f;ũ.Add(ŧ);}else if(ź==ž.Y){var Ŧ=MySprite.CreateText("[3|SPACE] CONFIRM",ә.Ӕ,ә.ӧ,0.4f);Ŧ.Position=new Vector2(0,5)+Ų.
TextureSize/2f;ũ.Add(Ŧ);}foreach(var ť in ř){ũ.Add(ť);}}}}void Ť(Ҿ m){Ť(MyTuple.Create(m.Ы,m.ќ));}void Ť(MyTuple<Ӄ,long>ţ){Д Ţ=ƞ[Ɵ]
;Ń š=Ɩ[ƕ];ƅ.ы.Ъ.ڜ(Ţ,š,ţ);ź=ž.Ž;}int Š=1000;І ş(){var Ş=new І();Ş.Ѕ=Vector3D.Transform(Vector3D.Forward*Š,ƅ.ԏ.ר.
WorldMatrix);return Ş;}}class ŝ:Ɔ{public override void Ƃ(){Ƅ[3]=()=>{ƅ.ԏ.ס();};Ƅ[4]=()=>{if(Ś<ś.Count){long Ŝ=ś[Ś].ќ;var r=ƅ.ы.Ъ.ڌ(
Ŝ);if(r<=0)return;ƅ.ы.Ъ.ڝ(Ŝ,r-1);}};Ƅ[5]=()=>{Ś=ƅ.փ(Ś,ś.Count,true);};Ƅ[6]=()=>{if(Ś<ś.Count){long Ŝ=ś[Ś].ќ;var r=ƅ.ы.Ъ.ڌ
(Ŝ);if(r>=4)return;ƅ.ы.Ъ.ڝ(Ŝ,r+1);}};Ƅ[8]=()=>{Ś=ƅ.փ(Ś,ś.Count,false);};}public override void ƃ(){Ū();Ŷ();ų();}List<х>ś=
new List<х>();int Ś=0;List<MySprite>ř=new List<MySprite>();public ŝ(){}void Ū(){var ū=ƅ.ы.М;ū.Ã();int ŷ=19;ū.È(
"====== LIDAR ======");ū.È();ū.È("DISABLED");ū.È();ū.È("===================");ƅ.א(ŷ,ƅ.ԏ.ע.Type.ToString(),ū);foreach(var Ų in ƅ.ԏ.ד){Ų.
FontColor=ә.ӹ;Ų.WriteText(ū.ToString());}}void Ŷ(){var ū=ƅ.ы.М;ū.Ã();ū.È("= TARGET PRIORITY =");ū.È();var ŵ=ƅ.ы.Ъ.ڛ();ś.Clear();
foreach(var ª in ŵ)if(ª.Key.Item1==Ӄ.ҿ)ś.Add((х)ª.Value);if(ś.Count<=Ś)Ś=0;if(ś.Count==0){ū.È("NO TARGETS");foreach(var Ų in ƅ.
ԏ.ת){Ų.WriteText(ū.ToString());Ų.FontColor=ә.ӹ;}return;}ū.È("8/5: SELECT");ū.È("4/6: -/+ PRIORITY");ū.È();for(int Ŵ=0;Ŵ<
12;Ŵ++){if(Ŵ<ś.Count){ū.Æ(Ŵ==Ś?"> ":"  ");int r=ƅ.ы.Ъ.ڌ(ś[Ŵ].ќ);if(r==0)ū.Æ("-- ");else if(r==1)ū.Æ("=- ");else if(r==2)ū.
Æ("== ");else if(r==3)ū.Æ("+= ");else if(r==4)ū.Æ("++ ");ƅ.א(14,ś[Ŵ].Ћ,ū);}else{ū.È();}}ū.È();foreach(var Ų in ƅ.ԏ.ת){Ų.
WriteText(ū.ToString());Ų.FontColor=ә.ӹ;}}void ų(){if(ƅ.ԏ.ש.Count==0)return;foreach(var Ų in ƅ.ԏ.ש){ř.Clear();ƅ.վ(ř);foreach(Ҿ ª
in ƅ.ы.Ъ.ڛ().Values){if(ª.Ы==Ӄ.Ӏ){ƅ.ԏ.ի(Ų,ª,ә.ӓ,ref ř,ռ.ז.Ք);}else if(ª.Ы==Ӄ.ҿ){ռ.ז Ř=ռ.ז.ժ;if(ś.Count>Ś&&ª==ś[Ś]){Ř|=ռ.ז.
ה;Ř|=ռ.ז.נ;}int r=ƅ.ы.Ъ.ڌ(ª.ќ);if(r==0)Ř|=ռ.ז.Փ|ռ.ז.Ք;else if(r==1)Ř|=ռ.ז.Ք;else if(r==3)Ř|=ռ.ז.Օ;else if(r==4)Ř|=ռ.ז.Օ|ռ
.ז.ו;ƅ.ԏ.ի(Ų,ª,r==0?ә.ӧ:ә.Ӧ,ref ř,Ř);}else if(ª.Ы==Ӄ.Ӂ){ƅ.ԏ.ի(Ų,ª,Color.Green,ref ř,ռ.ז.Օ);}}using(var ũ=Ų.DrawFrame()){
foreach(var ť in ř){ũ.Add(ť);}}}}}class ű:Ɔ{public override void Ƃ(){Ƅ[3]=()=>{ƅ.ԏ.ס();};Ƅ[4]=()=>{if(ǝ("SM")){Ǟ=true;return;}}
;Ƅ[5]=()=>{if(ǝ("LG")){Ǟ=true;return;}};Ƅ[6]=()=>{if(Ǡ==-1){ǟ="NO TARGET";}bool Ű=false;var Ů=ƅ.ы.а<خ>();if(Ů!=null){var
ŭ=ƅ.ы.Ъ.ڛ();var ů=MyTuple.Create(Ӄ.ҿ,Ǡ);if(!ŭ.ContainsKey(ů))return;foreach(var Ŭ in Ů.ڠ){if(Ŭ.Ϯ!=-1){var N=MyTuple.
Create(Ӄ.Ӏ,Ŭ.Ϯ);if(ŭ.ContainsKey(N)){Д Ţ=(Д)ŭ[N];if(Ţ.Џ.X>95&&Ţ.Џ.Y>20&&Ţ.Џ.Z>50){ƅ.ы.Ъ.ڜ(Ţ,Ń.Ľ,ů);Ű=true;Ǟ=true;}}}}}if(!Ű)ǟ=
"DRONES UNAVAILABLE";};Ƅ[7]=()=>{var Ů=ƅ.ы.а<خ>();if(Ů!=null){var ŭ=ƅ.ы.Ъ.ڛ();var ţ=MyTuple.Create(Ӄ.ӂ,(long)0);foreach(var Ŭ in Ů.ڠ){if(Ŭ.Ϯ
!=-1){var Ƒ=MyTuple.Create(Ӄ.Ӏ,Ŭ.Ϯ);if(ŭ.ContainsKey(Ƒ)){Д Ţ=(Д)ŭ[Ƒ];ƅ.ы.Ъ.ڜ(Ţ,Ń.Ŀ,ţ);}}}}};}public override void ƃ(){ǚ();
Ǖ();ų();}public void Ơ(){}List<MySprite>ř=new List<MySprite>();long Ǡ=-1;string ǟ=string.Empty;bool Ǟ=false;public ű(){}
bool ǝ(string ǜ){if(Ǡ>0){var ŭ=ƅ.ы.Ъ.ڛ();var N=MyTuple.Create(Ӄ.ҿ,Ǡ);Ҿ ª;if(ŭ.TryGetValue(MyTuple.Create(Ӄ.ҿ,Ǡ),out ª)){ӣ Ǜ=
new ӣ();Ǜ.ӝ("torpedo firetarget "+ǜ+" "+Ǡ);ƅ.ы.Х(Ǜ);return true;}}return false;}void ǚ(){var ū=ƅ.ы.М;ū.Ã();ƅ.ы.ظ(ї.і,ū);
foreach(var Ų in ƅ.ԏ.ד){Ų.WriteText(ū.ToString());Ų.FontColor=ә.ӹ;}}void Ǚ(long ǘ,long Ǘ){var ŭ=ƅ.ы.Ъ.ڛ();var ı=MyTuple.Create(
Ӄ.Ӏ,ǘ);var ǖ=MyTuple.Create(Ӄ.Ŀ,Ǘ);if(ŭ.ContainsKey(ı)){ƅ.ы.Ъ.ڜ((Д)ŭ[ı],Ń.ľ,ǖ);ƅ.ы.Ъ.ڜ((Д)ŭ[ı],Ń.Ŀ,ǖ,Ѯ.Ѭ);}}void Ǖ(){var
ū=ƅ.ы.М;ū.Ã();ū.È("===== CONTROL =====");ū.È();ū.È("3 - RAYCAST");ū.È();ū.È("4 - FIRE SMALL");ū.È("5 - FIRE LARGE");ū.È()
;ū.È("6 - DRONES ATTACK");ū.È("7 - DRONES RECALL");ū.È("8 - PAIR DRONES");ū.È();ū.È("===== CONTROL =====");foreach(var Ų
in ƅ.ԏ.ת){Ų.FontColor=ә.ӹ;Ų.WriteText(ū.ToString());}}void ų(){if(ƅ.ԏ.ש.Count==0)return;foreach(var Ų in ƅ.ԏ.ש){ř.Clear();
ƅ.վ(ř);float ǔ=100*100;long Ǔ=-1;foreach(Ҿ ª in ƅ.ы.Ъ.ڛ().Values){if(ª.Ы==Ӄ.Ӏ){var ǡ=(Д)ª;if((ǡ.ł&ł.Ѥ)!=0)continue;ռ.ז Ř=
ռ.ז.Ք;if(ǡ.А==А.Ĺ)Ř=ռ.ז.շ;else{var Ů=ƅ.ы.а<خ>();if(Ů!=null&&ǡ.А==А.ѩ&&Ů.ڡ.ContainsKey(ǡ.Е))Ř|=ռ.ז.ה;}ƅ.ԏ.ի(Ų,ª,ә.ӓ,ref ř,
Ř);}else if(ª.Ы==Ӄ.ҿ){ռ.ז Ř=ռ.ז.ժ;if(ª.һ<10){Ř=ռ.ז.Ք;ƅ.ԏ.ի(Ų,ª,ә.Ӧ,ref ř,Ř);}else{if(ª.ќ==Ǡ){Ř=ռ.ז.ժ|ռ.ז.נ|ռ.ז.ה|ռ.ז.ו|ռ.
ז.Ց|ռ.ז.Ր;if(Ǟ)Ř|=ռ.ז.Ւ;}var Ǵ=ƅ.ԏ.ի(Ų,ª,ә.Ӧ,ref ř,Ř).LengthSquared();if(Ǵ<ǔ){ǔ=Ǵ;Ǔ=ª.ќ;}}}}Ǡ=Ǔ;using(var ũ=Ų.DrawFrame()
){foreach(var ť in ř){ũ.Add(ť);}var ū=ƅ.ы.М;ū.Ã();ƅ.ы.ظ(ї.є,ū);ū.Æ(ǟ);var ǳ=ū.ToString();if(ǳ!=string.Empty){var Ŧ=
MySprite.CreateText(ǳ,ә.Ӕ,ә.Ӷ,0.9f);Ŧ.Position=new Vector2(0,-35)+Ų.TextureSize/2f;ũ.Add(Ŧ);}else{ƅ.ы.ظ(ї.ѕ,ū);ǳ=ū.ToString();if
(ǳ!=string.Empty){var ǲ=MySprite.CreateText(ū.ToString(),ә.ӕ,ә.Ӓ,0.3f);ǲ.Position=new Vector2(0,-25)+Ų.TextureSize/2f;ũ.
Add(ǲ);}}Ë Ǳ=new Ë();ƅ.ы.е.љ.э(Ǳ);var ǰ=MySprite.CreateText(Ǳ.ToString(),ә.Ӕ,ә.Ӷ,0.5f,TextAlignment.LEFT);ǰ.Position=new
Vector2(20,20);ũ.Add(ǰ);Ǳ.Ã();ь ǯ=ƅ.ы.а<Ͳ>();ǯ.Ш(ї.е);Ǳ.È("[torpedo_debug]");ђ.э(ǯ.ё(ї.е),Ǳ);var Ǯ=MySprite.CreateText(Ǳ.
ToString(),ә.Ӕ,ә.Ӷ,0.5f,TextAlignment.LEFT);Ǯ.Position=new Vector2(30,100)+Ų.TextureSize/2f;ũ.Add(Ǯ);}}Ǟ=false;}}class ǭ{public
static double Ǭ(double Ü){return Ü*(1+Ü*Ü*(0.1666666+0.075*Ü*Ü));}public static double ǫ(double Ü){if(Ü>Math.PI||Ü<-Math.PI)
return Math.Cos(Ü);return 1+Ü*Ü*(-0.5+Ü*Ü*(0.04166666+Ü*Ü*(-0.0013888888+Ü*Ü*0.0000248015)));}public static double Ǫ(double Ü)
{if(Ü>Math.PI||Ü<-Math.PI)return Math.Sin(Ü);return Ü*(1+Ü*Ü*(-0.1666666+Ü*Ü*(0.00833333+Ü*Ü*(-0.00019841269841+Ü*Ü*
0.00000275573))));}public static double ǩ(double Ü){if(Ü>Math.PI||Ü<-Math.PI)return Math.Tan(Ü);return Ǫ(Ü)/ǫ(Ü);}public static
double Ǩ(double ǧ,double ǒ,double Ǉ){return(MathHelper.Clamp(ǧ,ǒ,Ǉ)-ǒ)/(Ǉ-ǒ);}public static double Ǧ(double ǥ,double Ǥ,double
ǣ){return(1-ǥ)*Ǥ+ǥ*ǣ;}public static double Ǣ(double ǧ,double ǒ,double Ǉ,double ƶ,double Ƶ){return Ǧ(Ǩ(ǧ,ǒ,Ǉ),ƶ,Ƶ);}public
static Vector3D ƴ(Vector3D Ƴ,Vector3D Ʋ){if(Vector3D.IsZero(Ʋ))return Vector3D.Zero;return Ƴ.Dot(Ʋ)/Ʋ.LengthSquared()*Ʋ;}
public static double Ʊ(Vector3D º,Vector3D Ŗ){if(Vector3D.IsZero(º)||Vector3D.IsZero(Ŗ))return 0;else return Math.Acos(
MathHelper.Clamp(º.Dot(Ŗ)/Math.Sqrt(º.LengthSquared()*Ŗ.LengthSquared()),-1,1));}public static void ư(Vector3D Ư,Vector3D Ʈ,
Vector3D ƭ,Vector3D Ƭ,out double ƫ,out double ƪ){var Ʃ=ƴ(Ư,Ƭ);var ƨ=Ư-Ʃ;ƫ=Ʊ(Ʈ,ƨ);if(Vector3D.IsZero(ƨ)&&!Vector3D.IsZero(Ʃ))ƪ=
MathHelper.PiOver2;else ƪ=Ʊ(Ư,ƨ);ƫ=-1*Math.Sign(ƭ.Dot(Ư))*ƫ;ƪ=Math.Sign(Ƭ.Dot(Ư))*ƪ;if(Math.Abs(ƫ)<=1E-6&&Ư.Dot(Ʈ)<0){ƫ=Math.PI;}}
public static float Ƨ(Plane ƣ,Vector3 ƥ){return ƣ.Normal.Dot(ƥ)+ƣ.D;}public static double Ʀ(PlaneD ƣ,Vector3D ƥ){return ƣ.
Normal.Dot(ƥ)+ƣ.D;}public static bool Ƥ(PlaneD ƣ,Vector3D Ƣ,Vector3D ơ,out Vector3D Ĝ){Ĝ=Vector3D.Zero;var º=ƣ.Normal.Dot(ơ);
if(º==0)return false;Ĝ=Ƣ-ơ*(Ʀ(ƣ,Ƣ)/º);return true;}public static bool Ƹ(Plane ƣ,Vector3 Ƣ,Vector3 ơ,out Vector3 Ĝ){Ĝ=
Vector3.Zero;var º=ƣ.Normal.Dot(ơ);if(º==0)return false;Ĝ=Ƣ-ơ*(Ƨ(ƣ,Ƣ)/º);return true;}public static void ǐ(double Ǐ,double ǎ,
double Ǎ,List<IMyGyro>ǌ,MatrixD č){if(č==null)return;var ǋ=new Vector3D(-Ǐ,ǎ,Ǎ);var Ǌ=č;var ǉ=Vector3D.TransformNormal(ǋ,Ǌ);
foreach(var Ǒ in ǌ){var ǈ=Ǒ.WorldMatrix;var ǆ=Vector3D.TransformNormal(ǉ,Matrix.Transpose(ǈ));Ǒ.Pitch=(float)ǆ.X;Ǒ.Yaw=(float)ǆ
.Y;Ǒ.Roll=(float)ǆ.Z;Ǒ.GyroOverride=true;}}public static Vector3 ǅ(Random Ǆ,Vector3 ǃ){ǃ.Normalize();var ǂ=Vector3D.
CalculatePerpendicularVector(ǃ);ǂ.Normalize();var ǁ=ǂ.Cross(ǃ);var ǀ=Ǆ.NextDouble()*Math.PI*2;return ǂ*Math.Sin(ǀ)+ǁ*Math.Cos(ǀ);}}public class ƿ{
public int ƾ;public double ƽ;public double Ƽ;public double ƻ;public double ƺ;public double ƹ;IMyGridProgramRuntimeInfo Ʒ{get;
set;}public Queue<double>ŗ=new Queue<double>();public Queue<double>Ę=new Queue<double>();public Dictionary<string,ä>ã=new
Dictionary<string,ä>();double â;double á;public ƿ(IMyGridProgramRuntimeInfo Ñ,double à=0.01){Ʒ=Ñ;ƾ=(int)(1/à);ƽ=à;â=6;á=100.0/Ʒ.
MaxInstructionCount;}public void Ã(){Ƽ=0;ŗ.Clear();ƻ=0;ƺ=0;Ę.Clear();ƹ=0;}public void ß(){double Ñ=Ʒ.LastRunTimeMs;Ƽ+=(Ñ-Ƽ)*ƽ;ŗ.Enqueue(Ñ);
if(ŗ.Count>ƾ)ŗ.Dequeue();ƻ=ŗ.MaxBy(Ü=>Ü);}public void Þ(){double Ý=Ʒ.CurrentInstructionCount;ƺ+=(Ý-ƺ)*ƽ;Ę.Enqueue(Ý);if(Ę.
Count>ƾ)Ę.Dequeue();ƹ=Ę.MaxBy(Ü=>Ü);}public void Û(Ë Ó){Ó.È($"Avg Runtime = {Ƽ:0.0000}ms   ({Ƽ*â:0.00}%)");Ó.È(
$"Peak Runtime = {ƻ:0.0000}ms\n");Ó.È($"Avg Complexity = {ƺ:0.00}   ({ƺ*á:0.00}%)");Ó.È($"Peak Complexity = {ƹ:0.00}");}public void Ú(string Ø){ä Õ;if(!
ã.TryGetValue(Ø,out Õ)){Õ=new ä();ã[Ø]=Õ;}Õ.Ā=DateTime.Now.Ticks;}public void Ù(string Ø){long Ö=DateTime.Now.Ticks;ä Õ;
if(ã.TryGetValue(Ø,out Õ)){double Ñ=(Ö-Õ.Ā)*0.0001;Õ.Ð++;if(Õ.Ð>Õ.ÿ+1000)Õ.ā=0;Õ.æ+=Ñ;Õ.Ā=Ö;if(Õ.ā<Ñ){Õ.ā=Ñ;Õ.ÿ=Õ.Ð;}}}
public void Ô(Ë Ó){foreach(KeyValuePair<string,ä>Ò in ã){double Ñ=Ò.Value.æ/Ò.Value.Ð;Ó.È($"{Ò.Key} = {Ñ:0.0000}ms");}}public
class ä{public long Ð;public double æ;public double ā;public long Ā;public long ÿ;}}class þ:ь{string ý=string.Empty;List<
IMyCameraBlock>ü=new List<IMyCameraBlock>();List<IMyLargeTurretBase>û=new List<IMyLargeTurretBase>();Dictionary<MyDetectedEntityInfo,
float>ú=new Dictionary<MyDetectedEntityInfo,float>();List<MyDetectedEntityInfo>ù=new List<MyDetectedEntityInfo>();Dictionary<
long,MyDetectedEntityInfo>ø=new Dictionary<long,MyDetectedEntityInfo>();Dictionary<MyTuple<Ӄ,long>,Ҿ>ö;double õ=10000;int ô;
float ó;public þ(string ò="SE",int ð=30,float ï=0.25f){if(ò!=string.Empty){ý=$"[{ò}";}ô=ð;ó=ï;}public override void Ƃ(){ъ[
"designate"]=(î)=>{if(î.Ӛ==4){Vector3D m=new Vector3D();if(double.TryParse(î.ӛ(2),out m.X)&&double.TryParse(î.ӛ(3),out m.Y)&&double
.TryParse(î.ӛ(4),out m.Z)){Y(m);}}};í();ê();}void í(){ü.Clear();ŕ.ō(ы,(ì)=>{ŕ.ŉ(û,ì,null,(ë)=>{return ы.З==null||!ы.З.ʀ(ë
);});ŕ.ŉ(ü,ì,ý,(ë)=>{ë.EnableRaycast=true;return true;});});}void ê(){using(ڰ é=new ڰ()){if(é.ڬ(ы.ʬ)){õ=é.ڪ("Scanner",
"RaycastDistMax",(float)õ);}}}public override void ʝ(UpdateFrequency è){if(ы.К%10==0){ç();}}void ç(){ö=ы.Ъ.ڛ();ø.Clear();if(ы.З!=null){ы
.З.ɿ(ы.ʬ,ú);foreach(var m in ú.Keys){ø[m.EntityId]=m;}ú.Clear();if(ы.К%3001==0){ы.З.ʅ(ы.ʬ,ù);foreach(var m in ù){ø[m.
EntityId]=m;}ù.Clear();}int r=0;var u=ы.З.ɽ(ы.ʬ.CubeGrid.EntityId,r);if(u!=null)Q(u.Value,true);}else{foreach(var L in û){if(!L.
HasTarget)continue;var m=L.GetTargetedEntity();if(!m.IsEmpty()&&!ø.ContainsKey(m.EntityId)){ø[m.EntityId]=m;}}}foreach(var m in ø
){Q(m.Value);}foreach(var t in ö){if(t.Key.Item1!=Ӄ.ҿ)continue;х h=(х)t.Value;int r=ы.Ъ.ڌ(t.Key.Item2);if(r<1)continue;if
(!х.у(h))continue;if(h.ϯ+0.2*ә.Ӗ>ы.И)continue;if(h.ϯ+0.4*ә.Ӗ>ы.И&&r<4)continue;Vector3D q=t.Value.ҽ(ы.И);p(q,h);}}public
MyDetectedEntityInfo?p(Vector3D o,Ҿ m=null){float k=0f;х h=m as х;if(h!=null)k=h.һ*ó;int f=0;foreach(var S in ü){if(!S.IsWorking)continue;
var e=o;if(f>0)e+=new Vector3D(ы.Л.NextDouble()-0.5,ы.Л.NextDouble()-0.5,ы.Л.NextDouble()-0.5)*k;if(!S.CanScan(e))continue;
var Z=S.Raycast(e);if(!Z.IsEmpty()){if(Q(Z)){if(h==null||Z.EntityId==h.ќ)return Z;}else f++;}else{f++;if(h==null)break;}if(
f>5)break;}return null;}void Y(Vector3D X,int W=5){Vector3D V=(X-ы.Φ.GetPosition());if(V.LengthSquared()<1)return;V.
Normalize();MyDetectedEntityInfo?U=null;foreach(var S in ü){if(W<=0)break;if(S.IsWorking){var R=S.RaycastDistanceLimit-10;if(R<0)
{if(S.CanScan(X)){U=S.Raycast(X);if(U.HasValue&&!U.Value.IsEmpty()){Q(U.Value);return;}W--;}}else if(S.CanScan(R,V)){U=S.
Raycast(R,V);if(U.HasValue&&!U.Value.IsEmpty()){Q(U.Value);return;}W--;}}}}bool Q(MyDetectedEntityInfo P,bool O=false){if(P.
IsEmpty())return false;if(P.Type==MyDetectedEntityType.SmallGrid||P.Type==MyDetectedEntityType.LargeGrid){return Ï(P,O);}else
if(P.Type==MyDetectedEntityType.Asteroid||(P.Type==MyDetectedEntityType.Unknown&&P.Name=="MyVoxelMap")){var N=MyTuple.
Create(Ӄ.Ӂ,P.EntityId);if(!ö.ContainsKey(N)){Ѝ M=new Ѝ();M.һ=(float)(P.BoundingBox.Max-P.BoundingBox.Center).Length();M.ќ=P.
EntityId;M.Ѕ=P.BoundingBox.Center;ы.Ъ.ڙ(M);return true;}}else{var N=MyTuple.Create(Ӄ.ҿ,P.EntityId);Ҿ ª;if(ö.TryGetValue(N,out ª)
){х Î=(х)ª;Î.т(P,ы.И);}else{ы.е.љ.е("UnAdded TN="+O+" Intel Type="+P.Type.ToString()+" Name="+P.Name);}}return false;}
bool Ï(MyDetectedEntityInfo m,bool O=false){if(m.Relationship==MyRelationsBetweenPlayerAndBlock.Enemies||m.Relationship==
MyRelationsBetweenPlayerAndBlock.NoOwnership||(O&&m.Relationship==MyRelationsBetweenPlayerAndBlock.Neutral)){var N=MyTuple.Create(Ӄ.ҿ,m.EntityId);Ҿ Í;if
(!ö.TryGetValue(N,out Í)){Í=new х();}х Î=(х)Í;Î.т(m,ы.И);ы.Ъ.ڙ(Î);return true;}else if(m.Relationship==
MyRelationsBetweenPlayerAndBlock.Friends){var N=MyTuple.Create(Ӄ.Ӏ,m.EntityId);Ҿ Í;if(!ö.TryGetValue(N,out Í)){Í=new Д();}Д Ì=(Д)Í;Ì.ќ=m.EntityId;Ì.Ћ=m.
Name;Ì.ϯ=ы.И;Ì.Г=m.Position;Ì.ϰ=m.Velocity;ы.Ъ.ڙ(Ì);return true;}else throw new Exception("Unexpected Relationship="+m.
Relationship.ToString());;}}public class Ë{public StringBuilder Ê;public Ë(int É=256){Ê=new StringBuilder(É);}public Ë È(){Ê.
AppendLine();return this;}public Ë È(string Å){Ê.AppendLine(Å);return this;}public Ë Æ<Ç>(Ç Å){Ê.Append(Å);return this;}public Ë Æ
(char Å,int Ä){Ê.Append(Å,Ä);return this;}public void Ã(){Ê.Clear();}public int Â{get{return Ê.Length;}}public override
string ToString(){return Ê.ToString();}}public class Á{int À=0;string[]º;public bool µ{get{return º.Length>À;}}public string ñ
(){À+=1;if(º.Length>=À)return º[À-1];return String.Empty;}public Á(string Ă){º=Ă.Split(new[]{"\r\n","\r","\n"},
StringSplitOptions.None);}}[Flags]public enum Ń{Ĺ=0,Ł=1,ŀ=2,Ŀ=4,ľ=8,Ľ=16,ļ=32,Ļ=64}public enum ĺ{Ĺ,ĸ,ķ,Ķ}public interface ĵ{Ń Ĵ{get;}į ĳ(Ń
Ĳ,MyTuple<Ӄ,long>ı,Dictionary<MyTuple<Ӄ,long>,Ҿ>ĭ,double Ĭ,long İ);}public interface į{void Į(Dictionary<MyTuple<Ӄ,long>,
Ҿ>ĭ,double Ĭ,ƿ ī);ĺ Ī{get;}ł ł{get;}string ĩ{get;}}public struct ń:į{public ĺ Ī=>ĺ.Ķ;public ł ł=>ł.Ĺ;public void Į(
Dictionary<MyTuple<Ӄ,long>,Ҿ>ĭ,double Ĭ,ƿ ī){}public string ĩ=>"NullTask";}public static class ŕ{static Dictionary<string,
ITerminalAction>Ŕ=new Dictionary<string,ITerminalAction>();static Dictionary<string,ITerminalProperty>œ=new Dictionary<string,
ITerminalProperty>();public static bool Œ(IMyTerminalBlock ő,IMyTerminalBlock Ő){return ő.IsSameConstructAs(Ő);}public static
MyDefinitionId ŏ(string Ŏ){return MyDefinitionId.Parse(Ŏ);}public static void ō(П Ō,Action<IMyTerminalBlock>ŋ){Ō.ϊ.GetBlocksOfType<
IMyTerminalBlock>(null,(Ŗ)=>{if(Œ(Ō.ʬ,Ŗ))ŋ(Ŗ);return true;});}public static bool ŉ<Ç>(ref Ç Ŋ,IMyTerminalBlock đ,string ò,Func<Ç,bool>Ň=
null)where Ç:class{Ç ņ=đ as Ç;if(ņ!=null&&(Ň==null||Ň(ņ))){if(Ŋ==null||Ņ(đ,ò)){Ŋ=ņ;return true;}}return false;}public static
bool ŉ<Ç>(ICollection<Ç>ň,IMyTerminalBlock đ,string ò,Func<Ç,bool>Ň=null)where Ç:class{Ç ņ=đ as Ç;if(ņ!=null&&Ņ(đ,ò)&&(Ň==
null||Ň(ņ))){ň.Add(ņ);return true;}return false;}public static bool Ņ(IMyTerminalBlock đ,string ò){return String.
IsNullOrEmpty(ò)||đ.CustomName.Contains(ò);}public static void Ģ(IMyTerminalBlock đ,string Ė){ITerminalAction ĕ;if(Ŕ.TryGetValue(Ė,
out ĕ)){ĕ.Apply(đ);return;}ĕ=đ.GetActionWithName(Ė);Ŕ[Ė]=ĕ;ĕ.Apply(đ);}public static void Ĕ<Ç>(IMyTerminalBlock đ,string Đ,
Ç ē){ITerminalProperty ď;if(œ.TryGetValue(Đ,out ď)){ď.Cast<Ç>().SetValue(đ,ē);return;}ď=đ.GetProperty(Đ);œ[Đ]=ď;ď.Cast<Ç>
().SetValue(đ,ē);}public static Ç Ē<Ç>(IMyTerminalBlock đ,string Đ){ITerminalProperty ď;if(œ.TryGetValue(Đ,out ď)){return
ď.Cast<Ç>().GetValue(đ);}ď=đ.GetProperty(Đ);œ[Đ]=ď;return ď.Cast<Ç>().GetValue(đ);}public static IMyTerminalBlock Ď(
IMyTerminalBlock č,Vector3I X){var Č=new MatrixI(č.Orientation);var ċ=new Vector3I(-X.X,X.Y,-X.Z);Vector3I Ċ;Vector3I.Transform(ref ċ,
ref Č,out Ċ);Ċ+=č.Position;var ĉ=č.CubeGrid.GetCubeBlock(Ċ);return ĉ==null?null:ĉ.FatBlock as IMyTerminalBlock;}public
static IMyShipMergeBlock Ĉ(IMyShipMergeBlock ć){if(ć==null){return null;}Vector3I Ć=ć.Position+Base6Directions.GetIntVector(ć.
Orientation.TransformDirection(ć.BlockDefinition.SubtypeName.Length==24?Base6Directions.Direction.Up:Base6Directions.Direction.
Right));IMyShipMergeBlock ą=ć.CubeGrid.GetCubeBlock(Ć)?.FatBlock as IMyShipMergeBlock;if(ą==ć){return null;}return ą;}public
static double Ą(IMyCubeGrid ă){return(ă.WorldAABB.Max-ă.WorldAABB.Center).Length()+20;}public static string ė<Ç>(List<Ç>ę,
IMyCubeBlock ĝ)where Ç:class,IMyTerminalBlock{if(ę==null||ę.Count==0){return"";}else{StringBuilder Ó=new StringBuilder(ę.Count*5);
foreach(IMyTerminalBlock đ in ę){Ó.Append(ħ(đ,ĝ)).Append(',');}return Ó.ToString();}}public static string ħ(IMyCubeBlock đ,
IMyCubeBlock ĝ){if(đ==null){return"";}else{Vector3I Ğ=Ħ(đ.Position,ĝ);return Ğ.X+"."+Ğ.Y+"."+Ğ.Z;}}public static Vector3I Ħ(Vector3I
ĥ,IMyCubeBlock ĝ){Vector3I[]Ĥ={-Base6Directions.GetIntVector(ĝ.Orientation.Left),Base6Directions.GetIntVector(ĝ.
Orientation.Up),-Base6Directions.GetIntVector(ĝ.Orientation.Forward)};Vector3I[]ģ={new Vector3I(Ĥ[0].X,Ĥ[1].X,Ĥ[2].X),new Vector3I(
Ĥ[0].Y,Ĥ[1].Y,Ĥ[2].Y),new Vector3I(Ĥ[0].Z,Ĥ[1].Z,Ĥ[2].Z)};Vector3I Ğ=ĥ-ĝ.Position;Ğ=(Ğ.X*ģ[0])+(Ğ.Y*ģ[1])+(Ğ.Z*ģ[2]);var
Ĝ=(Ğ.X*Ĥ[0])+(Ğ.Y*Ĥ[1])+(Ğ.Z*Ĥ[2])+ĝ.Position;return Ğ;}public static bool Ĩ<Ç>(string Ğ,IMyCubeBlock ĝ,ref List<Ç>Ĝ)
where Ç:class,IMyCubeBlock{if(string.IsNullOrEmpty(Ğ)){return false;}string[]ġ=Ğ.Split(new char[]{','},StringSplitOptions.
RemoveEmptyEntries);foreach(string Ġ in ġ){if(string.IsNullOrEmpty(Ġ))continue;IMySlimBlock ĉ=ĝ.CubeGrid.GetCubeBlock(ğ(Ġ,ĝ));if(ĉ!=null&&
ĉ.IsFullIntegrity){Ç đ=ĉ.FatBlock as Ç;if(đ!=null){Ĝ.Add(đ);}else{return false;}}else{return false;}}return true;}public
static Vector3I ğ(string Ğ,IMyCubeBlock ĝ){Vector3I Ĝ=new Vector3I();if(Ğ!=null){var ě=Ğ.Split('.');int Ü,å,Ě;if(!int.TryParse
(ě[0],out Ü)||!int.TryParse(ě[1],out å)||!int.TryParse(ě[2],out Ě)){throw new Exception($"Failed parsing {Ğ}");}Ĝ.X=Ü;Ĝ.Y
=å;Ĝ.Z=Ě;Ĝ=ǵ(Ĝ,ĝ);}return Ĝ;}public static Vector3I ǵ(Vector3I ĥ,IMyCubeBlock ĝ){Vector3I[]Ĥ={-Base6Directions.
GetIntVector(ĝ.Orientation.Left),Base6Directions.GetIntVector(ĝ.Orientation.Up),-Base6Directions.GetIntVector(ĝ.Orientation.Forward)
};ĥ=(ĥ.X*Ĥ[0])+(ĥ.Y*Ĥ[1])+(ĥ.Z*Ĥ[2])+ĝ.Position;return ĥ;}}public class Ͳ:ь{public Ͳ(){Р=UpdateFrequency.Update1|
UpdateFrequency.Update10|UpdateFrequency.Update100;}public override void Ƃ(){ʶ["SM"]=new Ȭ(this,"SM");ʶ["LG"]=new Ȭ(this,"LG");ˤ();ê();
í();foreach(var ǜ in ʶ.Values){foreach(var ˢ in ǜ.Ȝ)ˢ.Color=ǜ.Ȣ?ә.ӷ:ә.ӵ;}ϓ(null,ϖ.ϕ);г(ї.е,(Ŗ)=>{foreach(var t in ʶ)Ŗ.È(
"Grp ["+t.Key+"] #"+t.Value.ʗ.Count);Ŗ.È("Active Torps:");foreach(var ɭ in ʴ){var ͱ=ɭ.ʠ!=null?ɭ.ʠ.ĩ:"null";var Ͱ=ɭ.Κ!=null?ɭ.Κ.
ќ.ToString():"null";Ŗ.È("Trp["+ͱ+"]["+ɭ.Υ+"]["+ɭ.Ζ+"] Tgt="+Ͱ);}});г(ї.і,(Ŗ)=>{Ŗ.È("== TORPEDO TUBES ==");Ŗ.È();foreach(
var t in ʶ){int ˬ=t.Value.ʔ;int ˮ=t.Value.ʗ.Count();if(ˮ>0)Ŗ.Æ(t.Value.ĩ).Æ(" [").Æ('|',ˬ).Æ('-',ˮ-ˬ).Æ(' ',Math.Max(0,8-ˮ)
).Æ(t.Value.Ȣ?"] AUTO \n":"] MANL \n");}});г(ї.ѕ,(Ŗ)=>{foreach(var t in ʶ){int ˮ=t.Value.ʗ.Count;if(ˮ>0){int ˬ=t.Value.ʔ;
Ŗ.È(t.Key+":"+ˬ);}}});}void ˤ(){ъ["toggleauto"]=(î)=>{var ˣ=î.ӛ(1);Ȭ ǜ;if(ʶ.TryGetValue((string)ˣ,out ǜ)){ǜ.Ȣ=!ǜ.Ȣ;
foreach(var ˢ in ǜ.Ȝ)ˢ.Color=ǜ.Ȣ?ә.ӷ:ә.ӵ;if(!ǜ.Ȣ)ʵ.AddRange(ǜ.ɔ.Keys);Ш(ї.і);Ш(ї.ѕ);}};ъ["fire"]=(î)=>{ϓ(î,ϖ.ϕ);};ъ["firetrick"
]=(î)=>{ϓ(î,ϖ.ț);};ъ["firespread"]=(î)=>{ϓ(î,ϖ.ϔ);};ъ["firetarget"]=(î)=>{Ȭ ǜ=null;if(!ʶ.TryGetValue(î.ӛ(1),out ǜ))return
;long ͳ=0;if(î.ӛ(2)!=null)long.TryParse(î.ӛ(2),out ͳ);if(ͳ>0){var ŭ=ы.Ъ.ڛ();foreach(var t in ŭ){if(t.Key.Item1!=Ӄ.ҿ)
continue;if(t.Key.Item2==ͳ){var m=(х)t.Value;Ƿ ͺ;ǜ.ɔ.TryGetValue(m,out ͺ);if(ͺ==null){ǜ.ɔ[m]=ͺ=new Ƿ();ͺ.ȏ=0;}ͺ.ȑ++;}}}};}bool Ή
(П Ō,Ȭ ǜ,х m){int Έ=(1<<(int)(m.ф));Έ&=ǜ.ȝ;return Έ!=0&&m.һ>ǜ.Ȟ&&(m.ҽ(Ō.И)-ы.ʬ.GetPosition()).Length()<ǜ.ȡ;}bool Ά(П Ō,Ȭ
ǜ,х m){return true;}private void ͽ(Ȭ ǜ,bool ͼ,Func<П,Ȭ,х,bool>ͻ){var ŭ=ы.Ъ.ڛ();foreach(var t in ŭ){if(t.Key.Item1!=Ӄ.ҿ)
continue;var m=(х)t.Value;Ƿ ͺ;ǜ.ɔ.TryGetValue(m,out ͺ);if(ͻ(ы,ǜ,m)){if(ͺ==null){ǜ.ɔ[m]=ͺ=new Ƿ();ͺ.ȏ=0;}if(ͼ)ͺ.ȫ=true;}else if(ͼ
&&ͺ!=null)ͺ.ȫ=false;}}void ͷ(){foreach(var ǜ in ʶ.Values){if(ǜ.ʔ==0||ы.Ϲ-ǜ.ȏ<ǜ.Ƞ)continue;if(ǜ.ɔ.Count>0){х Ͷ=null;Ƿ ʹ=
null;foreach(var t in ǜ.ɔ){var Z=t.Value;if(Z.ȑ>0||(Z.ȫ&&Ή(ы,ǜ,t.Key))){if(ʹ==null||Z.ȏ<ʹ.ȏ){ʹ=Z;Ͷ=t.Key;}}else{ʵ.Add(t.Key)
;}}if(ʹ!=null){if(ɰ(ǜ,Ͷ,false)!=null){ʹ.ȑ--;ʹ.ȏ=ы.Ϲ;continue;}}}else if(ǜ.Ȓ[0]>0){if(ɰ(ǜ,null,false)!=null)ǜ.Ȓ[0]--;}else
if(ǜ.Ȓ[1]>0){if(ɰ(ǜ,null,true)!=null)ǜ.Ȓ[1]--;}}}public override void ʝ(UpdateFrequency è){if((è&UpdateFrequency.Update100
)!=0){for(int Ŵ=0;Ŵ<ʷ.Count();Ŵ++){var ȩ=ʷ[Ŵ];if(ȩ!=null){if(ȩ.ʞ())ȩ.ʝ(ы.Ϲ);if(ȩ.Ȫ)ȩ.ʠ.ɚ&=~(1L<<ȩ.ʡ);else ȩ.ʠ.ɚ|=1L<<ȩ.ʡ;
}}var ɮ=ˌ.Ӥ();if(ɮ!=null){ɮ.ˎ(ы.Ϲ,this);}}if((è&UpdateFrequency.Update1)!=0){ˊ++;if(ˊ%9931==0){foreach(var ǜ in ʶ.Values)
{foreach(var t in ǜ.ɔ){if(ы.Ъ.ښ(MyTuple.Create(Ӄ.ҿ,t.Key.ќ))==double.MaxValue){ʵ.Add(t.Key);}}}}if(ʵ.Count>0){foreach(var
ǜ in ʶ.Values){foreach(var ʾ in ʵ){ǜ.ɔ.Remove(ʾ);}}ʵ.Clear();}if(ˊ%60==0){foreach(var ǜ in ʶ.Values){if(ǜ.Ȣ){ͽ(ǜ,true,Ή);
}}}ͷ();if(ˊ%6==0){ʳ.Clear();var ŭ=ы.Ъ.ڛ();foreach(var ɭ in ʴ){if(ɭ.Κ!=null){var ı=MyTuple.Create(Ӄ.ҿ,ɭ.Κ.ќ);if(!ŭ.
ContainsKey(ı)){ɭ.Κ=null;}else{ɭ.ʝ((х)ŭ[ı],ы.И);}}if(ɭ.Ζ&&ɭ.Κ==null){х ʽ=null;var ʼ=double.MaxValue;foreach(var ª in ŭ){if(ª.Key.
Item1!=Ӄ.ҿ)continue;var Î=(х)ª.Value;if(!Ή(ы,ɭ.ʠ,Î))continue;if(!х.у(Î))continue;if(ы.Ъ.ڌ(Î.ќ)<2)continue;double ʻ=(Î.ҽ(ы.И)-
ɭ.Φ.WorldMatrix.Translation).Length();if(ы.Ъ.ڌ(Î.ќ)==3)ʻ-=1000;if(ы.Ъ.ڌ(Î.ќ)==4)ʻ-=1000;if(ʻ<ʼ){ʼ=ʻ;ʽ=Î;}}ɭ.ʝ(ʽ,ы.И);}if(
ɭ.Λ)ʳ.Add(ɭ);}foreach(var ɭ in ʳ)ʴ.Remove(ɭ);}ʳ.Clear();foreach(var ɭ in ʴ){var ʺ=ә.ӗ/ә.Ӗ;var ʹ=ɭ.Φ.GetShipSpeed()*ʺ+(ɭ.Φ
.CubeGrid.GridSizeEnum==MyCubeSize.Large?11.5:3);ɭ.β();if(ɭ.Ψ&&ɭ.Κ!=null){if((ɭ.Φ.GetPosition()-ɭ.Κ.ҽ(ы.И)).LengthSquared
()<ʹ){ʳ.Add(ɭ);ɭ.ə();}else if(ɭ.Π!=null){if(ɭ.Π.CubeGrid==null||!ɭ.Π.CubeGrid.CubeExists(ɭ.Π.Position)){ʳ.Add(ɭ);ɭ.ə();}}
else if(ɭ.ü.Count>0){for(int Ŵ=0;Ŵ<ɭ.ü.Count;Ŵ++){if(!ɭ.ü[Ŵ].IsWorking)continue;MyDetectedEntityInfo ʸ=ɭ.ü[Ŵ].Raycast(ʹ+ɭ.ζ[
Ŵ]);if(ʸ.EntityId!=0&&(ʸ.Relationship==MyRelationsBetweenPlayerAndBlock.Enemies||ʸ.Relationship==
MyRelationsBetweenPlayerAndBlock.Neutral||ʸ.Relationship==MyRelationsBetweenPlayerAndBlock.NoOwnership)){ʳ.Add(ɭ);ɭ.ə();}}}else if(ɭ.Χ!=null&&ɭ.Χ.
IsWorking){ɭ.Χ.DetectedEntities(ʱ);if(ʱ.Count>0){ʱ.Clear();ʳ.Add(ɭ);ɭ.ə();}}}}foreach(var ɭ in ʳ)ʴ.Remove(ɭ);}}public ʧ[]ʷ=new ʧ[
16];public Dictionary<string,Ȭ>ʶ=new Dictionary<string,Ȭ>();public List<х>ʵ=new List<х>();public HashSet<ώ>ʴ=new HashSet<ώ
>();public List<ώ>ʳ=new List<ώ>();public List<IMyTerminalBlock>ʲ=new List<IMyTerminalBlock>();List<MyDetectedEntityInfo>ʱ
=new List<MyDetectedEntityInfo>();public class ʰ{IMyShipWelder ʯ;double ʿ;Dictionary<Ȭ,long>ʮ=new Dictionary<Ȭ,long>();
public ʰ(Ͳ ƅ,IMyShipWelder ɮ){ʯ=ɮ;ƅ.ˋ.TryParse(ɮ.CustomData);var ˡ=ƅ.ˋ.Get("Torpedo","Tubes").ToString();if(ˡ!=string.Empty){
var ˠ=ˡ.Split(',');foreach(var ˑ in ˠ){var ː=ˑ.Split('^');Ȭ ǜ=ƅ.ʶ[ː[0]];long ˍ;if(!ʮ.TryGetValue(ǜ,out ˍ))ʮ.Add(ǜ,0);ʮ[ǜ]=ˍ
|1L<<int.Parse(ː[1]);}}}public void ˏ(double ƀ,Ȭ ǜ,int ʟ){long ˍ;if(ʮ.TryGetValue(ǜ,out ˍ)){if((ˍ&(1L<<ʟ))==0)return;ʯ.
Enabled=false;ʿ=ƀ+ǜ.Ȥ;}}public void ˎ(double ƀ,Ͳ ʖ){if(ƀ<ʿ)return;foreach(var ǜ in ʖ.ʶ){long ˍ;if(ʮ.TryGetValue(ǜ.Value,out ˍ))
{if((ǜ.Value.ɚ&ˍ)!=0){ʯ.Enabled=true;return;}}}ʯ.Enabled=false;}}public Ѳ<ʰ>ˌ=new Ѳ<ʰ>();public MyIni ˋ=new MyIni();long
ˊ;void ˉ(MyIni ˈ,string ˇ,Ȭ ǜ){string Ø="Torpedo";if(ˈ.ContainsSection(Ø+"_"+ˇ)){Ø=Ø+"_"+ˇ;}ǜ.Ȩ=(float)ˈ.Get(Ø,
"GuidanceStartSeconds").ToDouble(2.0);ǜ.ȧ=ˈ.Get(Ø,"CruiseDistMin").ToDouble(1000);ǜ.ȧ*=ǜ.ȧ;ǜ.Ȧ=ˈ.Get(Ø,"PlungeDist").ToInt16(1000);ǜ.ȥ=ˈ.Get(Ø
,"HitOffset").ToDouble(0.0);ǜ.Ȥ=ˈ.Get(Ø,"ReloadCooldownMS").ToInt32(ǜ.Ȥ);ǜ.Ȣ=ˈ.Get(Ø,"AutoFire").ToBoolean();ǜ.ȡ=ˈ.Get(Ø,
"AutoFireRange").ToInt16(15000);ǜ.Ƞ=ˈ.Get(Ø,"AutoFireTubeMS").ToInt16(500);ǜ.ȟ=ˈ.Get(Ø,"AutoFireTargetMS").ToInt16(2000);ǜ.Ȟ=ˈ.Get(Ø,
"AutoFireRadius").ToInt16(30);ǜ.ȝ=ˈ.Get(Ø,"AutoFireSizeMask").ToInt16(1);ǜ.ț=ˈ.Get(Ø,"Trickshot").ToBoolean(false);ǜ.Ț=ˈ.Get(Ø,
"TrickshotDistance").ToInt32(1200);ǜ.ș=ˈ.Get(Ø,"TrickshotTerminalDistance").ToInt32(1000);ǜ.ș*=ǜ.ș;ǜ.Ș=ˈ.Get(Ø,"Evasion").ToBoolean();ǜ.ȗ=ˈ
.Get(Ø,"EvasionDistStart").ToInt32(2000);ǜ.ȗ*=ǜ.ȗ;ǜ.Ȗ=ˈ.Get(Ø,"EvasionDistEnd").ToInt32(500);ǜ.Ȗ*=ǜ.Ȗ;ǜ.ȓ=ˈ.Get(Ø,
"EvasionOffsetMagnitude").ToDouble(ǜ.ȓ);ǜ.ȕ=ˈ.Get(Ø,"EvasionAdjTimeMin").ToInt32(ǜ.ȕ);ǜ.Ȕ=ˈ.Get(Ø,"EvasionAdjTimeMax").ToInt32(ǜ.Ȕ);string ˆ=
"Torpedo_Parts";if(ˈ.ContainsSection(ˆ+"_"+ˇ)){ˆ=ˆ+"_"+ˇ;}List<MyIniKey>ˁ=new List<MyIniKey>();ˈ.GetKeys(ˆ,ˁ);foreach(var N in ˁ){var ʓ
=ˈ.Get(N).ToInt32();if(ʓ==0)continue;var Ĳ=MyItemType.Parse(N.Name);ǜ.ȣ[Ĳ]=ʓ;}}void ê(){MyIni é=new MyIni();if(!é.
TryParse(ы.ʬ.CustomData))return;string Ø="Torpedo";if(é.ContainsSection(Ø)){int τ=é.Get(Ø,"TorpedoTubeCount").ToInt16(16);if(ʷ.
Length!=τ){ʷ=new ʧ[τ];}}foreach(var ǜ in ʶ){ˉ(é,ǜ.Key,ǜ.Value);}}void í(){ы.ϊ.GetBlocksOfType<IMyTerminalBlock>(null,ς);ы.ϊ.
GetBlocksOfType<IMyTerminalBlock>(null,ι);}ʧ σ(int ʟ,MyCubeSize π){if(ʟ>=ʷ.Length)return null;var ȩ=ʷ[ʟ];if(ȩ==null){ȩ=new ʧ(ʟ,this);ȩ.
ʢ=π;ʷ[ʟ]=ȩ;var ǜ=ʶ[π==MyCubeSize.Small?"SM":"LG"];ǜ.ʕ(ȩ);ȩ.ʠ=ǜ;}return ȩ;}bool ς(IMyTerminalBlock đ){if(!ы.ʬ.
IsSameConstructAs(đ))return false;var ρ=đ.CustomName.IndexOf("[TRP");if(ρ==-1)return false;var π=đ.CubeGrid.GridSizeEnum;var ο=đ.
CustomName.IndexOf("[TRPW]");if(ο!=-1)ˌ.ҩ.Add(new ʰ(this,đ as IMyShipWelder));var ξ=đ.CustomName.IndexOf("[TRPT]");if(ξ!=-1){ˋ.
TryParse(đ.CustomData);var ν=ˋ.Get("Torpedo","ThrusterReleases").ToString();var μ=ν.Split(',');foreach(var λ in μ){var κ=λ.Split
('^');var ȩ=σ(int.Parse(κ[0]),π);if(ȩ==null)return false;if(ȩ.ʦ==null)ȩ.ʦ=new ʘ(đ,κ[1]);}}else{var ʚ=đ.CustomName.IndexOf
(']',ρ);if(ʚ==-1)return false;var ʙ=đ.CustomName.Substring(ρ+4,ʚ-ρ-4);int ʟ;if(!int.TryParse(ʙ,out ʟ))return false;var ȩ=
σ(ʟ,π);if(ȩ==null)return false;if(ȩ.ʦ==null){var ʌ=đ as IMyMechanicalConnectionBlock;if(ʌ!=null)ȩ.ʦ=new ʎ(ʌ);var ć=đ as
IMyShipMergeBlock;if(ć!=null)ȩ.ʦ=new ʊ(ć);}if(đ is IMyShipConnector)ȩ.ʥ=(IMyShipConnector)đ;}return false;}bool ι(IMyTerminalBlock đ){if(
!ы.ʬ.IsSameConstructAs(đ))return false;if(!đ.CustomName.Contains("[TRP]"))return false;if(!(đ is IMyInteriorLight))return
false;var ˇ=đ.CubeGrid.GridSizeEnum==MyCubeSize.Small?"SM":"LG";if(đ.CustomName.Contains("LG"))ˇ="LG";if(đ.CustomName.
Contains("SM"))ˇ="SM";Ȭ ǜ;if(ʶ.TryGetValue(ˇ,out ǜ)){var ˢ=(IMyInteriorLight)đ;ǜ.Ȝ.Add(ˢ);}return false;}public enum ϖ{ϕ,ț,ϔ,};
void ϓ(ӣ Ǜ,ϖ Ĳ){if(Ǜ==null)return;if(Ǜ.ӛ(1)==null)return;Ȭ ǜ=null;if(!ʶ.TryGetValue(Ǜ.ӛ(1),out ǜ))return;int ϒ=1;if(Ǜ.ӛ(2)!=
null)int.TryParse(Ǜ.ӛ(2),out ϒ);switch(Ĳ){case ϖ.ϕ:ǜ.Ȓ[0]=ϒ;break;case ϖ.ț:ǜ.Ȓ[1]=ϒ;break;case ϖ.ϔ:{int ϑ=Math.Min(ǜ.ʔ,ϒ);if
(ϑ==0)return;ͽ(ǜ,false,Ά);if(ǜ.ɔ.Count>0)while(ϑ>0){foreach(var t in ǜ.ɔ){if(ϑ--==0)break;t.Value.ȑ++;}}break;}}}public ώ
ɰ(Ȭ ǜ,х m=null,bool ɯ=false){if(ǜ==null||!ǜ.Ȫ)return null;var ɭ=ǜ.ɰ(m,ɯ);if(ɭ!=null){ʴ.Add(ɭ);ǜ.ȏ=ǜ.ƅ.ы.Ϲ;foreach(var Ϗ
in ɭ.Ρ)ʴ.Add(Ϗ);return ɭ;}return null;}}public class ώ{public enum ύ{ό,Ƃ,ϋ,ϊ,}public Ȭ ʠ;public List<IMyGyro>ω=new List<
IMyGyro>();public HashSet<IMyWarhead>ψ=new HashSet<IMyWarhead>();public HashSet<IMyConveyorSorter>χ=new HashSet<
IMyConveyorSorter>();public HashSet<IMyThrust>φ=new HashSet<IMyThrust>();public HashSet<IMyBatteryBlock>υ=new HashSet<IMyBatteryBlock>();
public HashSet<IMyGasTank>ϐ=new HashSet<IMyGasTank>();public List<IMyCameraBlock>ü=new List<IMyCameraBlock>();public List<
float>ζ=new List<float>();public IMySensorBlock Χ;public IMyShipController Φ;public int Υ;public string Τ;public HashSet<
IMyShipMergeBlock>Σ=new HashSet<IMyShipMergeBlock>();public HashSet<ώ>Ρ=new HashSet<ώ>();public IMyTerminalBlock Π;ɖ Ο;Ȅ Ξ=new Ȅ(Ɇ,Ʌ,10);
Ȅ Ν=new Ȅ(Ɇ,Ʌ,10);double Μ=0;public bool Λ=false;public Ҿ Κ=null;double Ι;Vector3D Θ;public Vector3D Η;public bool Ζ=
false;bool Ε=true;bool Δ=false;bool Γ=false;int ˊ=0;Vector3D Β;public ύ Α=ύ.ό;Vector3D ΐ=Vector3D.Zero;ύ Ώ=ύ.ό;Vector3D Ύ=
Vector3D.Zero;double Ό;public bool Ψ=false;public Ͳ Ί=null;public bool Ω(IMyTerminalBlock đ){bool ɲ=false;if(đ.CustomName.
Contains("[F]")){Π=đ;ɲ=true;}if(đ is IMyShipController){Φ=(IMyShipController)đ;ɲ=true;}if(đ is IMyGyro){ω.Add((IMyGyro)đ);ɲ=true
;}if(đ is IMyCameraBlock){var S=(IMyCameraBlock)đ;ü.Add(S);S.EnableRaycast=true;float θ;float.TryParse(S.CustomData,out θ
);ζ.Add(θ);ɲ=true;}if(đ is IMySensorBlock){Χ=(IMySensorBlock)đ;ɲ=true;}if(đ is IMyThrust){φ.Add((IMyThrust)đ);((IMyThrust
)đ).Enabled=false;ɲ=true;}if(đ is IMyWarhead){ψ.Add((IMyWarhead)đ);ɲ=true;}if(đ is IMyConveyorSorter){χ.Add((
IMyConveyorSorter)đ);ɲ=true;}if(đ is IMyShipMergeBlock){Σ.Add((IMyShipMergeBlock)đ);ɲ=true;}if(đ is IMyBatteryBlock){υ.Add((
IMyBatteryBlock)đ);((IMyBatteryBlock)đ).Enabled=false;ɲ=true;}if(đ is IMyGasTank){ϐ.Add((IMyGasTank)đ);((IMyGasTank)đ).Enabled=true;ɲ=
true;}return ɲ;}public void ɋ(double ε,Ȭ ǜ){Ζ=true;ʠ=ǜ;Ώ=ǜ.Ș?ύ.Ƃ:ύ.ό;Ε=ǜ.Ȧ>0;Ο=new ɖ(ω);var Ɋ=Φ.WorldMatrix;Ο.ɋ(ref Ɋ);
foreach(var ɱ in ϐ)ɱ.Stockpile=false;foreach(var δ in ω){δ.GyroOverride=true;δ.Enabled=true;}Μ=ε;var Ⱦ=Ί.ы.Л;Β=new Vector3D(Ⱦ.
NextDouble()-0.5,Ⱦ.NextDouble()-0.5,Ⱦ.NextDouble()-0.5);}void η(){foreach(var ć in Σ){ć.Enabled=false;}foreach(var ɭ in Ρ){ɭ.ɋ(Μ,ʠ
);if(ɭ.Κ==null)ɭ.Κ=Κ;}Ρ.Clear();}public void ʝ(х Κ,double ε){if(!Ζ)return;if(!ΰ()){foreach(var δ in ω){δ.Enabled=false;}Ɉ
();Λ=true;}if(Λ)return;if(ε-Μ<ә.Ӗ*ʠ.Ȩ)return;if(Κ==null)return;if(ε-Μ>ә.Ӗ*(ʠ.Ȩ+1)&&Ρ.Count>0)η();this.Κ=Κ;Vector3D γ=ɂ();
Γ=Γ&&γ.Dot(Vector3D.Normalize(Φ.GetShipVelocities().LinearVelocity))>.98;if(Δ!=Γ){Δ=Γ;foreach(var ʨ in φ)ʨ.
ThrustOverridePercentage=Γ?.25f:1f;}ί(γ);}public void β(){if(Ζ){ˊ++;if(ˊ==2){foreach(var ʨ in φ){ʨ.Enabled=true;ʨ.ThrustOverridePercentage=1;}
foreach(var α in υ){α.Enabled=true;}}}}public bool ΰ(){return ω.Count>0&&Φ!=null&&Φ.IsFunctional&&φ.Count>0;}void ί(Vector3D ή)
{double έ=Math.Abs(ή.X);double ά=Math.Abs(ή.Y);double Ϋ=Math.Abs(ή.Z);double Ϊ,ʭ;if(Ϋ<0.00001){Ϊ=ʭ=MathHelperD.PiOver2;}
else{bool ɉ=έ>Ϋ;bool ɳ=ά>Ϋ;Ϊ=ɘ(Math.Max(ɉ?(Ϋ/έ):(έ/Ϋ),0.00001));ʭ=ɘ(Math.Max(ɳ?(Ϋ/ά):(ά/Ϋ),0.00001));if(ɉ)Ϊ=MathHelperD.
PiOver2-Ϊ;if(ɳ)ʭ=MathHelperD.PiOver2-ʭ;if(ή.Z>0){Ϊ=(Math.PI-Ϊ);ʭ=(Math.PI-ʭ);}}if(double.IsNaN(Ϊ))Ϊ=0;if(double.IsNaN(ʭ))ʭ=0;Ϊ
*=ɗ(ή.X);ʭ*=ɗ(ή.Y);Ϊ=Ξ.Ǽ(Ϊ,2);ʭ=Ν.Ǽ(ʭ,2);if(Math.Abs(Ϊ)+Math.Abs(ʭ)>Ʉ){double ɇ=Ʉ/(Math.Abs(Ϊ)+Math.Abs(ʭ));Ϊ*=ɇ;ʭ*=ɇ;}Ο.Ȍ
((float)Ϊ);Ο.Ȋ((float)ʭ);Ο.Ȉ(Ƀ);}const double Ɇ=10;const double Ʌ=5;const double Ʉ=6.3;float Ƀ=0;Vector3D ɂ(){var o=Κ.ҽ(ʠ
.ƅ.ы.И);o+=(Β*Κ.һ*ʠ.ȥ);var Ɂ=o-Φ.WorldMatrix.Translation;var ɀ=Ɂ;var ȿ=Ɂ.LengthSquared();var Ⱦ=Ί.ы.Л;Ψ=Ψ?Ψ:ȿ<120*120;var
Ƚ=Φ.GetNaturalGravity();bool ȼ=Ƚ!=Vector3D.Zero;Ε=ȼ&&Ε;Α=ȼ?ύ.ό:Α;Γ=!ȼ&&(ȿ>ʠ.ȧ);if(Α==ύ.Ƃ){ΐ=ǭ.ǅ(Ⱦ,Ɂ);ΐ*=ʠ.Ț;Α=ύ.ϋ;}if(Ώ==
ύ.Ƃ){Ώ=ύ.ϋ;}if(Ώ==ύ.ϋ){if(ȿ<=ʠ.ȗ&&ȿ>=ʠ.Ȗ){if(Ό-Ί.ы.И<0){var Ȼ=ǭ.Ǩ(ȿ,ʠ.ȗ,ʠ.Ȗ);var Ⱥ=ǭ.Ǧ(Ȼ,ʠ.Ȕ,ʠ.ȕ);Ό=Ί.ы.И+Ⱥ;Ύ=ǭ.ǅ(Ⱦ,Ɂ);
var ȹ=ǭ.Ǧ(Ȼ,ʠ.ȓ*Κ.һ,Κ.һ);Ύ*=ȹ;}}else{Ύ=Vector3D.Zero;}}if(Α==ύ.ϋ){ɀ+=ΐ;if(ɀ.LengthSquared()<100*100||ȿ<ʠ.ș){ΐ=Vector3D.Zero
;Α=ύ.ό;}}if(Ε){var ȸ=Ƚ;ȸ.Normalize();var ȷ=Ɂ.Dot(-ȸ);if((Ɂ.LengthSquared()<ʠ.Ȧ*ʠ.Ȧ)&&ȷ>0){Ε=false;}if(Ε){ɀ-=ȸ*ʠ.Ȧ;if(ɀ.
LengthSquared()<300*300)Ε=false;}}ɀ+=Ύ;var ȶ=Φ.GetShipVelocities().LinearVelocity;Vector3D ȵ=Κ.Ҽ()-ȶ;var ȴ=Φ.GetShipSpeed();double ȳ=
ȶ.Dot(ref ɀ);if(ȳ>0){Vector3D Ȳ=ɀ/ɀ.LengthSquared();Vector3D ȱ=ȵ-(ȵ.Dot(ref ɀ)*Ȳ);Vector3D Ȱ;var ȯ=(Θ-Κ.Ҽ())*0.16667;Ȱ=ȯ-
Ƚ-(ȯ.Dot(ref ɀ)*Ȳ);bool Ȯ=ȴ>Ι+1;if(Ȯ){Γ=false;Η=ȶ+(3.5*1.5*(ȱ+(0.5*Ȱ)));}else{Η=ȶ+(3.5*(ȱ+(0.5*Ȱ)));}}else{Η=(ɀ*0.1)+ȵ;}Θ
=Κ.Ҽ();Ι=ȴ;return Vector3D.TransformNormal(Η,MatrixD.Transpose(Φ.WorldMatrix));}void Ɉ(){foreach(var ȭ in ψ)ȭ.IsArmed=
true;foreach(var ȭ in χ)ȭ.SetValueBool("WC_Arm",true);}public void ə(){foreach(var ȭ in ψ){ȭ.IsArmed=true;ȭ.Detonate();}
foreach(var ȭ in χ){ʠ.ƅ.ы.З.ʄ(ȭ,true,true);}}double ɘ(double Ü){return 0.785375*Ü-Ü*(Ü-1.0)*(0.2447+0.0663*Ü);}double ɗ(double
ē){return ē<0?-1:1;}}public class ɖ{Action<IMyGyro,float>[]ɕ={(ɓ,ɒ)=>{ɓ.Yaw=-ɒ;},(ɓ,ɒ)=>{ɓ.Yaw=ɒ;},(ɓ,ɒ)=>{ɓ.Pitch=-ɒ;},(
ɓ,ɒ)=>{ɓ.Pitch=ɒ;},(ɓ,ɒ)=>{ɓ.Roll=-ɒ;},(ɓ,ɒ)=>{ɓ.Roll=ɒ;}};List<IMyGyro>ɑ;byte[]ɐ;byte[]ɏ;byte[]Ɏ;int ɍ=0;public ɖ(List<
IMyGyro>Ɍ){ɑ=Ɍ;}public void ɋ(ref MatrixD Ɋ){if(ɑ==null){ɑ=new List<IMyGyro>();}ɐ=new byte[ɑ.Count];ɏ=new byte[ɑ.Count];Ɏ=new
byte[ɑ.Count];for(int Ŵ=0;Ŵ<ɑ.Count;Ŵ++){ɐ[Ŵ]=Ȑ(ɑ[Ŵ].WorldMatrix.GetClosestDirection(Ɋ.Up));ɏ[Ŵ]=Ȑ(ɑ[Ŵ].WorldMatrix.
GetClosestDirection(Ɋ.Left));Ɏ[Ŵ]=Ȑ(ɑ[Ŵ].WorldMatrix.GetClosestDirection(Ɋ.Forward));}ɍ=0;}public byte Ȑ(Base6Directions.Direction Ƕ){
switch(Ƕ){case Base6Directions.Direction.Up:return 1;case Base6Directions.Direction.Down:return 0;case Base6Directions.
Direction.Left:return 2;case Base6Directions.Direction.Right:return 3;case Base6Directions.Direction.Forward:return 4;case
Base6Directions.Direction.Backward:return 5;}return 0;}public void Ȏ(bool ȍ){Ȇ();for(int Ŵ=0;Ŵ<ɑ.Count;Ŵ++){if(Ŵ==ɍ)ɑ[Ŵ].GyroOverride=ȍ
;else ɑ[Ŵ].GyroOverride=false;}}public void Ȍ(float ȋ){Ȇ();if(ɍ<ɑ.Count){ɕ[ɐ[ɍ]](ɑ[ɍ],ȋ);}}public void Ȋ(float ȉ){if(ɍ<ɑ.
Count){ɕ[ɏ[ɍ]](ɑ[ɍ],ȉ);}}public void Ȉ(float ȇ){if(ɍ<ɑ.Count){ɕ[Ɏ[ɍ]](ɑ[ɍ],ȇ);}}void Ȇ(){while(ɍ<ɑ.Count){if(ɑ[ɍ].
IsFunctional){break;}else{IMyGyro ȅ=ɑ[ɍ];ȅ.Enabled=ȅ.GyroOverride=false;ȅ.Yaw=ȅ.Pitch=ȅ.Roll=0f;ɍ++;}}}}public class Ȅ{double ȃ;
public double Ȃ;public double ȁ;double Ȁ;public Ȅ(double ǿ,double Ǿ,float ǽ=60f){Ȃ=ǿ;ȁ=Ǿ;Ȁ=ǽ;}public double Ǽ(double Ğ,int ǻ){
double Ǻ=Math.Round(Ğ,ǻ);double ǹ=(Ǻ-ȃ)*Ȁ;ȃ=Ǻ;return(Ȃ*Ğ)+(ȁ*ǹ);}public void Ǹ(){ȃ=0;}}public class Ƿ{public double ȏ;public
int ȑ;public bool ȫ;}public class Ȭ{public string ĩ{get;set;}public Ͳ ƅ;public bool Ȫ{get{foreach(ʧ ȩ in ʗ){if(ȩ.Ȫ)return
true;}return false;}}public float Ȩ=2;public double ȧ=10000;public int Ȧ=1000;public double ȥ=0;public int Ȥ=5000;public
Dictionary<MyItemType,int>ȣ=new Dictionary<MyItemType,int>();public bool Ȣ=false;public int ȡ=15000;public int Ƞ=500;public int ȟ=
2000;public int Ȟ=30;public int ȝ=1;public List<IMyInteriorLight>Ȝ=new List<IMyInteriorLight>();public bool ț=false;public
float Ț=1200;public float ș=1000;public bool Ș=false;public float ȗ=2000*2000;public float Ȗ=800*800;public int ȕ=500;public
int Ȕ=1000;public double ȓ=2;public long[]Ȓ=new long[2];public Dictionary<х,Ƿ>ɔ=new Dictionary<х,Ƿ>();public double ȏ;
public long ɚ;public HashSet<ʧ>ʗ{get;set;}public ώ ɰ(х m=null,bool ɯ=true){foreach(ʧ ȩ in ʗ){if(ȩ.Ȫ)return ȩ.ɰ(m,ɯ);}return
null;}public Ȭ(Ͳ ʖ,string Ɗ){ĩ=Ɗ;ƅ=ʖ;ʗ=new HashSet<ʧ>();}public void ʕ(ʧ ȩ){ʗ.Add(ȩ);}public int ʔ{get{int ʓ=0;foreach(ʧ ȩ
in ʗ){if(ȩ.Ȫ)ʓ++;}return ʓ;}}}public interface ʒ{bool ʑ{get;}bool ʐ();bool ʏ(ref List<IMyTerminalBlock>ʋ);}public class ʎ:
ʒ{public bool ʑ=>false;private IMyMechanicalConnectionBlock ʍ;public ʎ(IMyMechanicalConnectionBlock ʌ){ʍ=ʌ;}public bool ʐ
(){if(ʍ.Top==null)return false;ʍ.Detach();return true;}public bool ʏ(ref List<IMyTerminalBlock>ʋ){if(ʍ.Top==null)return
false;return ŕ.Ĩ(ʍ.CustomData,ʍ.Top,ref ʋ);}}public class ʊ:ʒ{public bool ʑ=>false;private IMyShipMergeBlock ʉ;public ʊ(
IMyShipMergeBlock ć){ʉ=ć;}public bool ʐ(){var ʈ=ŕ.Ĉ(ʉ);if(ʈ==null)return false;ʈ.Enabled=false;return true;}public bool ʏ(ref List<
IMyTerminalBlock>ʋ){var ʈ=ŕ.Ĉ(ʉ);if(ʈ==null||!ʈ.IsFunctional||!ʈ.Enabled)return false;return ŕ.Ĩ(ʈ.CustomData,ʈ,ref ʋ);}}public class ʘ:
ʒ{public bool ʑ=>true;IMyTerminalBlock ʬ;Vector3I ʪ;public ʘ(IMyTerminalBlock č,string ʩ){ʬ=č;ʪ=ŕ.ğ(ʩ,č);}public bool ʐ()
{var ʨ=ʬ.CubeGrid.GetCubeBlock(ʪ)?.FatBlock as IMyThrust;if(ʨ==null)return false;ʨ.Enabled=true;ʨ.
ThrustOverridePercentage=1;return true;}public bool ʏ(ref List<IMyTerminalBlock>ʋ){var ʨ=ʬ.CubeGrid.GetCubeBlock(ʪ)?.FatBlock as IMyThrust;if(ʨ
==null||!ʨ.IsFunctional)return false;return ŕ.Ĩ(ʨ.CustomData,ʨ,ref ʋ);}}public class ʧ{public ʒ ʦ;public IMyShipConnector
ʥ;public double ʤ;public ώ ʣ;Ͳ ƅ;ώ[]ʫ=new ώ[16];public MyCubeSize ʢ;public int ʡ;public Ȭ ʠ;public bool Ȫ=>ʣ!=null;public
List<ʧ>ʗ{get;set;}public ʧ(int ʟ,Ͳ ʖ){ƅ=ʖ;ʗ=new List<ʧ>();ʡ=ʟ;ɰ(null);}public bool ʞ(){return ʦ!=null;}public void ʝ(double
ʜ){if(ʤ>ʜ)return;if(ʣ==null)ʇ();}public bool ʛ(IMyTerminalBlock ɲ){if(ɲ.CustomName.StartsWith("<SUB")){var ʚ=ɲ.CustomName
.IndexOf('>');if(ʚ==-1)return false;var ʙ=ɲ.CustomName.Substring(4,ʚ-4);int ʟ;if(!int.TryParse(ʙ,out ʟ))return false;if(ʫ
[ʟ]==null){ʫ[ʟ]=new ώ();ʫ[ʟ].Τ=ʟ.ToString();ʣ.Ρ.Add(ʫ[ʟ]);}return ʫ[ʟ].Ω(ɲ);}else{return ʣ.Ω(ɲ);}}void ʇ(){ʣ=new ώ();for(
int Ŵ=0;Ŵ<ʫ.Length;Ŵ++){ʫ[Ŵ]=null;}ƅ.ʲ.Clear();if(!ʦ.ʏ(ref ƅ.ʲ)){ʣ=null;return;}foreach(var ɲ in ƅ.ʲ){ʛ(ɲ);}if(!ʣ.ΰ()){ʣ=
null;return;}for(int Ŵ=0;Ŵ<ʫ.Length;Ŵ++){if(ʫ[Ŵ]!=null){if(!ʫ[Ŵ].ΰ()){ʣ=null;return;}}}if(ʥ!=null){if(ʥ.Status==
MyShipConnectorStatus.Connectable)ʥ.Connect();if(ʥ.Status!=MyShipConnectorStatus.Connected){ʣ=null;return;}}foreach(var ɱ in ʣ.ϐ)ɱ.Stockpile=
true;ƅ.Ш(ї.і);ƅ.Ш(ї.ѕ);}public ώ ɰ(х m=null,bool ɯ=true){if(ƅ.ы.И==0)return null;if(ʣ==null)return null;if(!ʦ.ʐ())return
null;ʤ=ƅ.ы.Ϲ+ʠ.Ȥ;if(ʦ.ʑ){foreach(var ɮ in ƅ.ˌ.ҩ){ɮ.ˏ(ƅ.ы.Ϲ,ʠ,ʡ);}}ʠ.ɚ|=1L<<ʡ;if(ʥ!=null&&ʥ.Status==MyShipConnectorStatus.
Connected)ʥ.OtherConnector.Enabled=false;var ɭ=ʣ;ʣ=null;ƅ.Ш(ї.і);ƅ.Ш(ї.ѕ);ɭ.Α=ʠ.ț||ɯ?ώ.ύ.Ƃ:ώ.ύ.ό;ɭ.Ί=ƅ;foreach(var ɬ in ɭ.Ρ){ɬ.Ί=
ƅ;ɬ.Α=ɭ.Α;}ɭ.Υ=ʡ;ɭ.ɋ(ƅ.ы.И,ʠ);ɭ.Κ=m;return ɭ;}}public class ɫ{private Action<IMyTerminalBlock,bool,bool,int>ɪ;private
Func<IMyTerminalBlock,int,MyDetectedEntityInfo>ɩ;private Func<IMyTerminalBlock,bool>ɨ;private Action<IMyTerminalBlock,
IDictionary<MyDetectedEntityInfo,float>>ɧ;private Action<IMyTerminalBlock,ICollection<MyDetectedEntityInfo>>ɦ;private Func<long,int
,MyDetectedEntityInfo>ɥ;private Action<IMyTerminalBlock,long,int>ɤ;private Func<long,bool>ɣ;private Func<Sandbox.ModAPI.
Ingame.IMyTerminalBlock,int,bool,bool,bool>ɢ;static public void ɡ(IMyTerminalBlock ɠ,ref ɫ ɟ){if(ɟ!=null)return;var ɞ=ɠ.
GetProperty("WcPbAPI")?.As<IReadOnlyDictionary<string,Delegate>>().GetValue(ɠ);if(ɞ==null)return;ɟ=new ɫ();ɟ.ɝ(ɞ);}public void ɝ(
IReadOnlyDictionary<string,Delegate>ɜ){ɛ(ɜ,"GetWeaponTarget",ref ɩ);ɛ(ɜ,"ToggleWeaponFire",ref ɪ);ɛ(ɜ,"HasCoreWeapon",ref ɨ);ɛ(ɜ,
"GetSortedThreats",ref ɧ);ɛ(ɜ,"GetObstructions",ref ɦ);ɛ(ɜ,"GetAiFocus",ref ɥ);ɛ(ɜ,"SetWeaponTarget",ref ɤ);ɛ(ɜ,"HasGridAi",ref ɣ);ɛ(ɜ,
"IsWeaponReadyToFire",ref ɢ);}private void ɛ<Ç>(IReadOnlyDictionary<string,Delegate>ɜ,string Ɗ,ref Ç ɴ)where Ç:class{if(ɜ==null){ɴ=null;
return;}Delegate ʆ;if(!ɜ.TryGetValue(Ɗ,out ʆ))throw new Exception($"{GetType().Name} wc1: {Ɗ} {typeof(Ç)}");ɴ=ʆ as Ç;if(ɴ==
null)throw new Exception($"{GetType().Name} wc2: {Ɗ} {typeof(Ç)} {ʆ.GetType()}");}public void ʄ(IMyTerminalBlock ɷ,bool ʃ,
bool ʂ,int ɶ=0)=>ɪ?.Invoke(ɷ,ʃ,ʂ,ɶ);public MyDetectedEntityInfo?ʁ(IMyTerminalBlock ɷ,int ɶ=0)=>ɩ?.Invoke(ɷ,ɶ);public bool ʀ(
IMyTerminalBlock ɷ)=>ɨ?.Invoke(ɷ)??false;public void ɿ(IMyTerminalBlock ɾ,IDictionary<MyDetectedEntityInfo,float>ň)=>ɧ?.Invoke(ɾ,ň);
public void ʅ(IMyTerminalBlock ɾ,ICollection<MyDetectedEntityInfo>ň)=>ɦ?.Invoke(ɾ,ň);public MyDetectedEntityInfo?ɽ(long ɼ,int
r=0)=>ɥ?.Invoke(ɼ,r);public void ɻ(IMyTerminalBlock ɷ,long m,int ɶ=0)=>ɤ?.Invoke(ɷ,m,ɶ);public bool ɺ(long ɹ)=>ɣ?.Invoke(
ɹ)??false;public bool ɸ(Sandbox.ModAPI.Ingame.IMyTerminalBlock ɷ,int ɶ=0,bool Ь=true,bool ɵ=false)=>ɢ?.Invoke(ɷ,ɶ,Ь,ɵ)??
false;