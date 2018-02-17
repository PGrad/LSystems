﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class LSystem : MonoBehaviour {

	public Rules rules;
	public void Awake() {
	}

	public void Generate() {
		StringBuilder nextAxiom = new StringBuilder();
		string production;
		foreach(char c in rules.sentence) {
			production = c.ToString();
			foreach(Rule rule in rules.rules)
				if(rule.LHS == c) {
					production = rule.RHS;
					break;
				}
			nextAxiom.Append(production);
		}
		rules.sentence = nextAxiom.ToString();
	}
}
