using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myMath;
using MicroFEMCore.MaterialModels;

namespace MicroFEMCore.Elements
{
    public class Element
    {
        /// <summary>
        /// Purpose:
        /// Created By: Scott_Stapleton
        /// Created On: 4/15/2024 1:49:06 PM
        /// </summary>
        #region Protected Members

        protected Material elementMaterial;
        protected double[] q;
        protected double[] f;
        protected double[,] k;

        protected int[] localToGlobalConnectivity;
        protected int nDOFperNode;
        protected double[][] nodalCoordinates;
        #endregion

        #region Public Members
        public virtual double[] Q { get { return q; } set { q = value; } }
        public virtual double[] F { get { return f; } set { f = value; } }
        public virtual double[,] K { get { return K; } set { k = value; } }

        #endregion

        #region Constructor
        public Element(Material elementMaterial, int[] localToGlobalConnectivity, double[][] nodalCoordinates, int nDOFperNode)

        {
            this.elementMaterial = elementMaterial;
            this.nDOFperNode = nDOFperNode;
            this.localToGlobalConnectivity = localToGlobalConnectivity;
            this.nodalCoordinates = nodalCoordinates;

            //Initiate k and f
            k = new double[localToGlobalConnectivity.Length * nDOFperNode, localToGlobalConnectivity.Length * nDOFperNode];
            q = new double[localToGlobalConnectivity.Length * nDOFperNode];
            f = new double[localToGlobalConnectivity.Length * nDOFperNode];
        }
        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

        #region Static Methods

        #endregion
    }
}
