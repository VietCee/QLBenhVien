   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   DataGridStyle1  �� 
TargetType&    System.Windows.Controls.DataGrid �� Property �� Value5  /System.Windows.Controls.DataGridLengthConverter �� 
TargetType �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions	    SelectAllCommand
 �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight � Maximum �� Orientation �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility � Value �� Mode �� Mode  �� ScrollableWidth! �� ViewportWidth," �� %ComputedHorizontalScrollBarVisibility# �� Triggers$ ]� 
Conditions% �� Property& �� Value  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow' ��Name( �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?  9System.Windows.Controls.Primitives.DataGridCellsPresenter)   
ItemsPanelA	  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter*   DetailsVisibility$+   SelectiveScrollingOrientation;
  5System.Windows.Controls.SelectiveScrollingOrientation, 
  Vertical#-    RowDetailsScrollingConverter:  4System.Windows.Controls.Primitives.DataGridRowHeader
.   Row/ P� Property0 P� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        &	 �
    &	     &	 �    �� 5      "    6#   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � �� �#2225286'   �� 5	   
    � ��$ 0q�6,   �� 5
   
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5   
    � �� . 6:   �� 5   
    �@��PanningMode$
 Both=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    �@  AutoGenerateColumns .  60   �� 5   
    �@  HeadersVisibility$ Column=�6.   �� 5   
    � ��$ 0 10 0 0q�6#   �� 5   
    �@  SelectionMode$ Single=�6*   �� 5   
    �@  SelectionUnit$ FullRow=�6*   �� 5   
    �@  CanUserAddRows .  6+   �� 5   
    �@  CanUserDeleteRows .  6.   �� 5   
    �@  CanUserResizeColumns .  61   �� 5   
    �@  CanUserReorderColumns .  62   �� 5   
    � ��$ 13(�6%   �� 5   
    �@  ColumnWidth$ * 6(   �� 5   
    �@  GridLinesVisibility$
 None=�60   �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� #��z��6   #��z��6G   #��z��6s   # z��6�    . ._�5      �� $ DG_ScrollViewer��6'   |�.  ��5      �� 5    "   " ��62   .R�5!   &   �  5"   *   �� 5#   .   $
��Auto �6?   �� 5$   .   $��* �6?   �� 5%   .   $
��Auto �6?    5'   *   �� 5(   .   $
��Auto �6<   �� 5)   .   $��* �6<   �� 5*   .   $
��Auto �6<   .+�5,   *   �� #��Z	 61   |�.  ��6r   C� *�� $"
 DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5-   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 5.   *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 5/   *   $ PART_VerticalScrollBar��64   $��2��6T   # z 6d   $ Vertical=�6�   $��1��6�   # z 6  #y�z 6I   6�   �� *VerticalOffset+$ OneWay=� �� $ TemplatedParent=�6I  � 50   *   $��1��6/   $��2��6?    51   .   �� 52   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 53   2   $��* �6C   .+�55   .   �� $ PART_HorizontalScrollBar��68   $��1��6Z   # z  6j   $ 
Horizontal=�6�   # z! 6  #y�z" 6D   6�   �� *HorizontalOffset+$ OneWay=� �� $ TemplatedParent=�6D  56   +   57   '   58   #   .��5:      �� # z 6-   5;      5<      5=      5?      # 5@   
   ]� 5A      $ 5B      �� 5C      % �@��
IsGrouping& . 66   �� 5D      "% �@%�IsVirtualizingWhenGrouping& .  6X   ./�5F      ��  � �� .  6B   5G      5I      �� 5J      "   6'   .�5K   
   ��  � ��
 ���� 6'   �� 5L   
    � ��$ Center=�6.   �� 5M   
    �@�FocusVisualStyle 6-   Z� �� 5N   
    � ��$
 15 0q�6#   �� 5O   
    � �� 5P      �� 5Q      "  6"   .R�5R      �� #��z��6   $��0q�6G    . ._�5S      �� # z 6+   5T      5U      5W      5Y      �� 5[      "   6/   .�5\   
   ��  � ��$ Center=�65   �� 5]   
    � ��
 ���� 6'   �� 5^   
    � �� �#69717d6'   �� 5_   
    � ��$ 
15 0 15 10q�6#   5a      �� 5c      "   6&   .�5d   
   ��  � ��
 �����6'   �� 5e   
    � ��$ 0 4 0 0q�6#   �� 5f   
    �@J�SnapsToDevicePixels . 60   �� 5g   
    �@=�ErrorTemplate 65   Z� �� 5h   
    �@ ValidationErrorTemplate 5i      �� 5j      .R�5k      �� 
���  ��$��2,0,0,0q�61   $��!��6B   $��Center=�6K   5l      5n      �� 5o   
    � �� 5p      �� 5q      "  6"   .R�5r      �� $' 
DGR_Border��6   $	 0 8q�61   #��z��6?   $��0q�6i   $( 5��6}    . ._�5s         5t      �� 5u   "   $
��Auto �63   �� 5v   "   $��* �63    5x      �� 5y   "   $��* �60   �� 5z   "   $
��Auto �60   .+�5|        $��1��65   #��z) 6E   # z 6o   	  5}      $��1��67   $��1��6G   #y�z* 6k  + 6T   �� *AreRowDetailsFrozen+# Z, # Z-  �� "   6k    5~      $��2��60   $+ Vertical=�6A   y�6�   �� *HeadersVisibility+# Z. # Z  �� "   5      5�      5�      5�      # 5�   
   P� 5�      / �@J�IsMouseOver0 . . �5�      ��  � �� �#623ed06/   �� 5�       � �� �#ffffff6/   5�      P� 5�      / �@ 
IsSelected0 . . �5�      ��  � �� �#623ed06/   �� 5�       � �� �#ffffff6/   5�      ]� 5�      $ 5�      �� 5�      % �@ 
IsSelected& . 66   �� 5�      % �@��IsSelectionActive& .  6F   ./�5�      ��  � �� �#dfdfdf6/   5�      5�      5�      