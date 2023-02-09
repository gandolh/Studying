import 'package:flutter/material.dart';
import 'dart:math' as math;
import 'CustomWidgets.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const TabsSamplePage1();
    // return StatefullComponent();
    // return const BuildSample();
    // return const ScrollPower();
    // return const StackAndCustomComponents();
    // return const Flexbox();
    // return const CenteredElement();
    // return const BasicSample();
  }
}
