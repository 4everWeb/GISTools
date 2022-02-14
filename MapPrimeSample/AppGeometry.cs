using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using GGeometryLib;
using System.Windows.Forms;

namespace MapPrimeSample
{
    class AppGeometry
    {
 

        public static IGeometryCollection MakeSplitSingleGeometry(IGeometry srcSingleGeom, ILineString line)
        {
            IGeometryCollection splitGeomColection = new GeometryCollection();

            if (srcSingleGeom.GeometryType != eGeometryType.eGeometryTypePolygon &&
                srcSingleGeom.GeometryType != eGeometryType.eGeometryTypeLineString)
                return splitGeomColection;

            ISpatialOperator2 so = srcSingleGeom.Clone() as ISpatialOperator2;
            IGeometry geomA = null;
            IGeometry geomB = null;
            so.Cut(line, out geomA, out geomB);
            if (geomA == null || geomB == null)
                return splitGeomColection;

            splitGeomColection.AddGeometry(geomA);

            IGeometryCollection geomBCol = geomB as IGeometryCollection;
            for (int m = 0; m < geomBCol.NumGeometries; m++)
            {
                splitGeomColection.AddGeometry(geomBCol.Geometry[m]);
            }
            return splitGeomColection;
        }

        public static IGeometryCollection MakeSplitMultiGoemetry(IGeometry srcMultiGeom, ILineString line)
        {
            IGeometryCollection splitMultiGeomColection = new GeometryCollection();
            IGeometryCollection srcMultiGeomCol = srcMultiGeom as IGeometryCollection;

            for (int m = 0; m < srcMultiGeomCol.NumGeometries; m++)
            {
                IGeometryCollection splitGoemCol = MakeSplitSingleGeometry(srcMultiGeomCol.Geometry[m], line);

                if (splitGoemCol.NumGeometries == 0)
                {
                    splitMultiGeomColection.AddGeometry(srcMultiGeomCol.Geometry[m]);
                }
                else
                {
                    for (int r = 0; r < splitGoemCol.NumGeometries; r++)
                    {
                        splitMultiGeomColection.AddGeometry(splitGoemCol.Geometry[r]);
                    }
                }
            }

            return splitMultiGeomColection;
        }



        public static IGeometry MakeUnion(List<IGeometry> srcGeomList)
        {
            IGeometry baseGeom = srcGeomList[0].Clone();
            eGeometryType geoType = baseGeom.GeometryType;

            for (int i = 1; i < srcGeomList.Count; i++)
            {
                ISpatialOperator2 oper = baseGeom as ISpatialOperator2;
                IGeometry addGeom = srcGeomList[i].Clone();
                IGeometry newUnionGeom = null;
                oper.Union(addGeom, out newUnionGeom);

                if (newUnionGeom.GeometryType == eGeometryType.eGeometryTypeGeometryCollection)
                {
                    IGeometryCollection geomColl = null;
                    if (geoType == eGeometryType.eGeometryTypePoint || geoType == eGeometryType.eGeometryTypeMultiPoint)
                        geomColl = new MultiPoint();
                    else if (geoType == eGeometryType.eGeometryTypeLineString || geoType == eGeometryType.eGeometryTypeMultiLineString)
                        geomColl = new MultiLineString();
                    else if (geoType == eGeometryType.eGeometryTypePolygon || geoType == eGeometryType.eGeometryTypeMultiPolygon)
                        geomColl = new MultiPolygon();

                    if (geomColl != null)
                    {
                        IGeometryCollection unionGeomColl = newUnionGeom as IGeometryCollection;
                        for (int g = 0; g < unionGeomColl.NumGeometries; g++)
                        {
                            IGeometry subGeom = unionGeomColl.Geometry[g];
                            eGeometryType subGeoType = subGeom.GeometryType;
                            if (geoType == subGeoType)
                                geomColl.AddGeometry(subGeom);
                            else if (geoType == eGeometryType.eGeometryTypeMultiPoint && subGeoType == eGeometryType.eGeometryTypePoint)
                                geomColl.AddGeometry(subGeom);
                            else if (geoType == eGeometryType.eGeometryTypeMultiLineString && subGeoType == eGeometryType.eGeometryTypeLineString)
                                geomColl.AddGeometry(subGeom);
                            else if (geoType == eGeometryType.eGeometryTypeMultiPolygon && subGeoType == eGeometryType.eGeometryTypePolygon)
                                geomColl.AddGeometry(subGeom);
                        }
                    }
                    baseGeom = geomColl;
                }
                else
                    baseGeom = newUnionGeom;
            }
            return baseGeom;
        }




    }
}
