﻿namespace PCBVI.Controls.Basic.InspectionStandard
{
    partial class InspectionStandardList
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bdsInspectionStandardType = new System.Windows.Forms.BindingSource(this.components);
            this.bdsInspectionStandard = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionStandardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionStandardTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inspectionStandardIdDataGridViewTextBoxColumn,
            this.inspectionStandardTypeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsInspectionStandard;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(703, 150);
            this.dgvList.TabIndex = 0;
            // 
            // bdsInspectionStandardType
            // 
            this.bdsInspectionStandardType.DataSource = typeof(PCBVI.Data.InspectionStandardType);
            // 
            // bdsInspectionStandard
            // 
            this.bdsInspectionStandard.DataSource = typeof(PCBVI.Data.InspectionStandard);
            // 
            // inspectionStandardIdDataGridViewTextBoxColumn
            // 
            this.inspectionStandardIdDataGridViewTextBoxColumn.DataPropertyName = "InspectionStandardId";
            this.inspectionStandardIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.inspectionStandardIdDataGridViewTextBoxColumn.Name = "inspectionStandardIdDataGridViewTextBoxColumn";
            // 
            // inspectionStandardTypeDataGridViewTextBoxColumn
            // 
            this.inspectionStandardTypeDataGridViewTextBoxColumn.DataPropertyName = "InspectionStandardTypeId";
            this.inspectionStandardTypeDataGridViewTextBoxColumn.DataSource = this.bdsInspectionStandardType;
            this.inspectionStandardTypeDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.inspectionStandardTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.inspectionStandardTypeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inspectionStandardTypeDataGridViewTextBoxColumn.HeaderText = "검사유형명";
            this.inspectionStandardTypeDataGridViewTextBoxColumn.Name = "inspectionStandardTypeDataGridViewTextBoxColumn";
            this.inspectionStandardTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inspectionStandardTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inspectionStandardTypeDataGridViewTextBoxColumn.ValueMember = "InspectionStandardTypeId";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "비고";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // InspectionStandardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "InspectionStandardList";
            this.Size = new System.Drawing.Size(703, 150);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInspectionStandard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsInspectionStandardType;
        private System.Windows.Forms.BindingSource bdsInspectionStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionStandardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn inspectionStandardTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}
